using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Web;
using DocumentFormat.OpenXml;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProgrammingLearningTasks.Configurations;
using ProgrammingLearningTasks.Database.Entities;
using ProgrammingLearningTasks.Database.Repositories;
using ProgrammingLearningTasks.Models.ProgrammingTasks;
using ProgrammingLearningTasks.Utils;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace ProgrammingLearningTasks.Controllers
{
    public class ProgrammingTasksController : Controller
    {
        private readonly ProgrammingTaskRepository _taskRepository;
        private readonly UserRepository _userRepository;
        private readonly JsonSerializerSettings _jsSerializerSettings;
        private readonly ViewRender _viewRender;

        public ProgrammingTasksController(ProgrammingTaskRepository taskRepository, UserRepository userRepository,
            ViewRender viewRender)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
            _viewRender = viewRender;
            _jsSerializerSettings = new JsonSerializerSettings {ContractResolver = new LowercaseContractResolver()};
        }

        [HttpGet]
        public IActionResult Index()
        {
            var topics = _taskRepository.GetAllTopics();

            var topicContainer = new TopicTreeContainer();
            topicContainer.FillTopicJsView(topics);

            ViewBag.JsonTreeData =
                JsonConvert.SerializeObject(topicContainer.TopicTreeJsViewNodes, _jsSerializerSettings);

            return View(topicContainer);
        }

        [HttpGet]
        public IActionResult TopicTasks(int id)
        {
            return PartialView(new TopicTaskIdModel() {Id = id});
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddTopic()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddTopic(AddTopicViewModel topicModel)
        {          
            var parentTopic = _taskRepository.GetParentTopic(topicModel.ParentName);

            if (topicModel.Name == null)
            {
                ModelState.AddModelError("Name", "Введите название темы");
                return View();
            }

            var topic = new Topic
            {
                Name = topicModel.Name,
                ParentId = parentTopic?.Id
            };

            _taskRepository.AddTopic(topic);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddTask(int? topicId)
        {
            if (topicId == null)
                return View();

            var topic = _taskRepository.GetTopicById(topicId.Value);

            if (topic == null)
                return View();

            var addTaskViewModel = new AddTaskViewModel
            {
                TopicName = topic.Name
            };

            return View(addTaskViewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddTask(AddTaskViewModel taskViewModel)
        {
            var userId = GetUserId();
            var author = _userRepository.GetUserById(userId);
            var topic = _taskRepository.GetTopicByName(taskViewModel.TopicName);

            if (topic == null || taskViewModel.TopicName == null)
            {
                ModelState.AddModelError("TopicName", "Такой темы не существует");
                return View();
            }

            if (taskViewModel.Name == null)
            {
                ModelState.AddModelError("Name", "Обязательное поле");
                return View();
            }

            var task = new ProgrammingTask
            {
                Author = author,
                Comment = taskViewModel.Comment,
                Complexity = taskViewModel.Complexity,
                Name = taskViewModel.Name,
                InputDataText = taskViewModel.InputDataText,
                OutputDataText = taskViewModel.OutputDataText,
                TestValues = taskViewModel.TestValues?.Where(w => w.Input != null && w.Output != null).Select(s =>
                    new TestValue
                    {
                        Input = s.Input,
                        Output = s.Output
                    }).ToArray(),
                Text = taskViewModel.Text,
                Topic = topic
            };

            var entity = _taskRepository.AddProgrammingTask(task);

            return RedirectToAction("EditTask", new {id = entity.Id});
        }

        [HttpPost]
        [Authorize]
        public IActionResult UploadFiles(int id)
        {
            var task = _taskRepository.GetProgrammingTask(id);

            if (task == null)
                return RedirectToAction("PageNotFound", "Home");

            foreach (var file in Request.Form.Files)
            {
                using var fileStream = file.OpenReadStream();
                using var memoryStream = new MemoryStream();
                fileStream.CopyTo(memoryStream);

                var decodedFileName = HttpUtility.UrlDecode(file.FileName);
                var fileName = Path.GetFileNameWithoutExtension(decodedFileName);
                var fileExtenstion = Path.GetExtension(decodedFileName);

                if (fileExtenstion == ".jpg" || fileExtenstion == ".png" || fileExtenstion == ".jpeg")
                {
                    var image = new Image
                    {
                        FileName = fileName,
                        Content = memoryStream.ToArray(),
                        Extension = fileExtenstion
                    };

                    task.Images.Add(image);
                }
                else
                {
                    var nestedFile = new NestedFile
                    {
                        FileName = fileName,
                        Content = memoryStream.ToArray(),
                        Extension = fileExtenstion
                    };

                    task.NestedFiles.Add(nestedFile);
                }
            }

            _taskRepository.UpdateProgrammingTask(task);

            return RedirectToAction("Task", new {id});
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditTask(int id)
        {
            var task = _taskRepository.GetProgrammingTask(id);
            var viewModel = new EditTaskViewModel
            {
                Comment = task.Comment,
                Complexity = task.Complexity,
                Id = task.Id,
                Name = task.Name,
                TopicName = task.Topic.Name,
                ImageIds = task.Images.Select(s => s.Id).ToArray(),
                InputDataText = task.InputDataText,
                OutputDataText = task.OutputDataText,
                NestedFiles = task.NestedFiles.Select(s => new NestedFileViewModel
                {
                    FileNameWithExtension = s.FileName + s.Extension,
                    Id = s.Id
                }).ToArray(),
                Text = task.Text,
                TestValues = task.TestValues.Select(s => new TestValueViewModel
                {
                    Input = s.Input,
                    Output = s.Output
                }).ToArray()
            };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditTask(EditTaskViewModel editTaskModel)
        {
            var task = _taskRepository.GetProgrammingTask(editTaskModel.Id);
            var topic = _taskRepository.GetTopicByName(editTaskModel.TopicName);

            if (task == null)
                return RedirectToAction("PageNotFound", "Home");

            if (topic == null || editTaskModel.TopicName == null)
            {
                ModelState.AddModelError("TopicName", "Такой темы не существует");
                return View(editTaskModel);
            }

            task.Comment = editTaskModel.Comment;
            task.Complexity = editTaskModel.Complexity;
            task.CreationDate = DateTime.Now;
            task.Name = editTaskModel.Name;
            task.InputDataText = editTaskModel.InputDataText;
            task.OutputDataText = editTaskModel.OutputDataText;

            task.TestValues = editTaskModel.TestValues?.Where(w => w.Input != null && w.Output != null).Select(s =>
                new TestValue
                {
                    Input = s.Input,
                    Output = s.Output
                }).ToList();

            task.Text = editTaskModel.Text;

            if (topic != null)
                task.Topic = topic;

            _taskRepository.UpdateProgrammingTask(task);

            return RedirectToAction("Task", new {editTaskModel.Id});
        }

        [HttpGet]
        [Authorize]
        public IActionResult DeleteTask(int id)
        {
            var task = _taskRepository.GetProgrammingTask(id);

            if (task == null)
                return RedirectToAction("PageNotFound", "Home");

            _taskRepository.DeleteProgrammingTask(task);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public IActionResult DeleteImage(int id, int taskId)
        {
            var image = _taskRepository.GetImage(id);

            if (image == null)
                return RedirectToAction("PageNotFound", "Home");

            _taskRepository.DeleteImage(image);

            return RedirectToAction("EditTask", new {id = taskId});
        }

        [HttpGet]
        [Authorize]
        public IActionResult DeleteNestedFile(int id, int taskId)
        {
            var nestedFile = _taskRepository.GetNestedFile(id);

            if (nestedFile == null)
                return RedirectToAction("PageNotFound", "Home");

            _taskRepository.DeleteNestedFile(nestedFile);

            return RedirectToAction("EditTask", new {id = taskId});
        }

        [HttpGet]
        public IActionResult GetTopicNamesLikeQuery([FromQuery] string request)
        {
            var data = _taskRepository.GetTopicNamesLikeQuery(request);
            return Json(new {data});
        }

        [HttpGet]
        public IActionResult GetTopicTasks(int id)
        {
            var tasks = _taskRepository.GetProgrammingTaskByTopicId(id);

            var data = new List<TopicTasksModel>();
            foreach (var task in tasks)
            {
                data.Add(new TopicTasksModel
                {
                    Id = task.Id,
                    Name = task.Name,
                    Author = task.Author.FullName,
                    Complexity = task.Complexity,
                    CreationDate = task.CreationDate.ToShortDateString(),
                });
            }

            return Json(new {data});
        }

        [HttpGet]
        public IActionResult DeleteTopic(int id)
        {
            var topic = _taskRepository.GetTopicById(id);

            if (topic == null)
                return RedirectToAction("PageNotFound", "Home");

            _taskRepository.DeleteTopic(topic);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Task(int id)
        {
            var task = _taskRepository.GetProgrammingTask(id);

            if (task == null)
                return RedirectToAction("PageNotFound", "Home");

            var taskViewModel = new TaskViewModel
            {
                Id = task.Id,
                Author = $"{task.Author?.FullName} - {task.Author?.Position}",
                Comment = task.Comment,
                Complexity = task.Complexity,
                Name = task.Name,
                Text = task.Text,
                InputDataText = task.InputDataText,
                OutputDataText = task.OutputDataText,
                CreationDate = task.CreationDate.ToString("dd.MM.yyyy"),
                TestValues = task.TestValues.Select(s => new TestValueViewModel
                {
                    Input = s.Input,
                    Output = s.Output
                }).ToArray(),
                TopicName = task.Topic?.Name,
                NestedFiles = task.NestedFiles?.Select(s => new NestedFileViewModel
                {
                    Id = task.Id,
                    FileNameWithExtension = s.FileName + s.Extension
                }).ToArray(),
                ImageIds = task.Images?.Select(s => s.Id).ToArray(),
                HasSolutions = task.Solutions.Any()
            };

            return View(taskViewModel);
        }

        [HttpGet]
        public IActionResult Solutions(int taskId)
        {
            var task = _taskRepository.GetSolutions(taskId);

            if (task == null)
                return RedirectToAction("PageNotFound", "Home");

            if (task.Solutions == null || !task.Solutions.Any())
                return RedirectToAction("PageNotFound", "Home");

            var solutionViews = new List<SolutionViewModel>();
            foreach (var solution in task.Solutions)
            {
                solutionViews.Add(new SolutionViewModel
                {
                    Id = solution.Id,
                    Code = solution.Code,
                    Text = solution.Text,
                    LangName = solution.ProgrammingLanguage?.Name,
                });
            }

            return View(new SolutionViewContainer
            {
                SolutionViewModels = solutionViews,
                TaskId = task.Id,
                TaskName = task.Name
            });
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddSolution(int taskId)
        {
            return View(new AddSolutionViewModel
            {
                TaskId = taskId
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddSolution(AddSolutionViewModel solutionViewModel)
        {
            var progLang = _taskRepository.GetProgrammingLanguageByName(solutionViewModel.LangName);
            var task = _taskRepository.GetProgrammingTask(solutionViewModel.TaskId);

            if (progLang == null)
            {
                progLang = new ProgrammingLanguage
                {
                    Name = solutionViewModel.LangName
                };
            }

            var solution = new Solution
            {
                Code = solutionViewModel.Code,
                Text = solutionViewModel.Text,
                ProgrammingLanguage = progLang
            };

            task.Solutions.Add(solution);
            _taskRepository.UpdateProgrammingTask(task);

            return RedirectToAction("Solutions", new {taskId = solutionViewModel.TaskId});
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditSolution(int id, int taskId)
        {
            var solution = _taskRepository.GetSolution(id);

            return View(new UpdateSolutionViewModel
            {
                Id = id,
                Code = solution.Code,
                Text = solution.Text,
                LangName = solution.ProgrammingLanguage.Name,
                TaskId = taskId
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult EditSolution(UpdateSolutionViewModel solutionViewModel)
        {
            var solution = _taskRepository.GetSolution(solutionViewModel.Id);

            if (solution == null)
                return RedirectToAction("PageNotFound", "Home");

            var progLang = _taskRepository.GetProgrammingLanguageByName(solutionViewModel.LangName);

            if (progLang == null)
            {
                progLang = new ProgrammingLanguage
                {
                    Name = solutionViewModel.LangName
                };
            }

            solution.Code = solutionViewModel.Code;
            solution.Text = solutionViewModel.Text;
            solution.ProgrammingLanguage = progLang;

            _taskRepository.UpdateSolution(solution);

            return RedirectToAction("Solutions", new {solutionViewModel.TaskId});
        }

        [HttpGet]
        [Authorize]
        public IActionResult DeleteSolution(int id, int taskId)
        {
            var solution = _taskRepository.GetSolution(id);

            if (solution == null)
                return RedirectToAction("PageNotFound", "Home");

            _taskRepository.DeleteSolution(solution);

            return RedirectToAction("Solutions", new {taskId});
        }

        [HttpGet]
        public IActionResult GetProgrammingLanguagesLikeQuery([FromQuery] string request)
        {
            var data = _taskRepository.GetProgrammingLanguagesLikeQuery(request);
            return Json(new {data});
        }

        [HttpGet]
        public IActionResult DownloadImage(int id)
        {
            var image = _taskRepository.GetImage(id);

            if (image == null)
                return BadRequest();

            return File(image.Content, MediaTypeNames.Image.Jpeg, image.FileName + image.Extension);
        }

        [HttpGet]
        public IActionResult DownloadNestedFile(int id)
        {
            var file = _taskRepository.GetNestedFile(id);

            if (file == null)
                return BadRequest();

            return File(file.Content, "application/octet-stream", file.FileName + file.Extension);
        }

        [HttpGet]
        public IActionResult DownloadDocxReport(int taskId)
        {
            var task = _taskRepository.GetProgrammingTask(taskId);

            if (task == null)
                return BadRequest();
            
            var taskViewModel = new TaskReportViewModel
            {
                Id = task.Id,
                Author = $"{task.Author?.FullName} - {task.Author?.Position}",
                Comment = task.Comment,
                Complexity = task.Complexity,
                Name = task.Name,
                Text = task.Text,
                InputDataText = task.InputDataText,
                OutputDataText = task.OutputDataText,
                CreationDate = task.CreationDate.ToString("dd.MM.yyyy"),
                TestValues = task.TestValues.Select(s => new TestValueViewModel
                {
                    Input = s.Input,
                    Output = s.Output
                }).ToArray(),
                TopicName = task.Topic?.Name
            };

            var baseUrl = $"{Request.Scheme}://{Request.Host.Value}{Request.PathBase.Value}";
            
            var nestedImages = task.Images?.Select(s => new NestedFileReportViewModel
            {
                FileNameWithExtension = s.FileName + s.Extension,
                Url = Flurl.Url.Combine(baseUrl, "ProgrammingTasks", "DownloadImage", $"{s.Id}")
            });

            var nestedFiles = task.NestedFiles?.Select(s => new NestedFileReportViewModel
            {
                FileNameWithExtension = s.FileName + s.Extension,
                Url = Flurl.Url.Combine(baseUrl, "ProgrammingTasks", "DownloadNestedFile", $"{s.Id}")
            });

            var nestedToReportFiles = nestedImages
                .Concat(nestedFiles)
                .ToArray();

            taskViewModel.NestedFiles = nestedToReportFiles;

            var html = _viewRender.Render("ProgrammingTasks/TaskToReportGenerate", taskViewModel);
            var doc = WordGenerator.HtmlToWord(html);
            return File(doc, "application/octet-stream", $"task{task.Id}.docx");
        }

        private int GetUserId()
        {
            var userIdClaim = User.Claims
                .FirstOrDefault(f => f.Type == "uid");

            var userId = int.Parse(userIdClaim.Value);
            return userId;
        }
    }
}