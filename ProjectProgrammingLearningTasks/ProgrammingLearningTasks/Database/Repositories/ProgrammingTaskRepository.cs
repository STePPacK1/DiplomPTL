using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProgrammingLearningTasks.Database.Entities;
using ProgrammingLearningTasks.Models.ProgrammingTasks;

namespace ProgrammingLearningTasks.Database.Repositories
{
    public class ProgrammingTaskRepository
    {
        private readonly ProgrammingLearningTasksContext _context;

        public ProgrammingTaskRepository(ProgrammingLearningTasksContext context)
        {
            _context = context;
        }

        public Topic[] GetAllTopics()
        {
            return _context.Topics.ToArray();
        }

        public ProgrammingTask[] GetProgrammingTaskByTopicId(int topicId)
        {
            return _context.ProgrammingTasks
                .Include(i => i.Topic)
                .Include(i => i.Author)
                .Where(w => w.Topic.Id == topicId)
                .Union(
                    _context.ProgrammingTasks
                        .Include(i => i.Topic)
                        .Include(i => i.Author)
                        .Where(w => w.Topic.ParentId == topicId)
                )
                .ToArray();
        }

        public ProgrammingTask GetProgrammingTask(int id)
        {
            return _context.ProgrammingTasks
                .Include(i => i.Author)
                .Include(i => i.Images)
                .Include(i => i.NestedFiles)
                .Include(i => i.TestValues)
                .Include(i => i.Topic)
                .Include(i => i.Solutions)
                .Include(i => i.Topic)
                .FirstOrDefault(f => f.Id == id);
        }

        public Image GetImage(int id)
        {
            return _context.Images
                .FirstOrDefault(f => f.Id == id);
        }

        public NestedFile GetNestedFile(int id)
        {
            return _context.NestedFiles
                .FirstOrDefault(f => f.Id == id);
        }

        public ProgrammingTask GetSolutions(int taskId)
        {
            return _context.ProgrammingTasks
                .Include(i => i.Solutions)
                .ThenInclude(i => i.ProgrammingLanguage)
                .FirstOrDefault(w => w.Id == taskId);
        }

        public Solution GetSolution(int id)
        {
            return _context.Solutions
                .Include(i => i.ProgrammingLanguage)
                .FirstOrDefault(f => f.Id == id);
        }

        public void UpdateSolution(Solution solution)
        {
            _context.Solutions.Update(solution);
            _context.SaveChanges();
        }

        public void DeleteSolution(Solution solution)
        {
            _context.Solutions.Remove(solution);
            _context.SaveChanges();
        }

        public void AddTopic(Topic topic)
        {
            _context.Topics.Add(topic);
            _context.SaveChanges();
        }

        public Topic GetParentTopic(string parentName)
        {
            if (parentName == null)
                return null;

            return _context.Topics.FirstOrDefault(f => f.Name == parentName);
        }

        public string[] GetTopicNamesLikeQuery(string query)
        {
            return _context.Topics
                .AsEnumerable()
                .Where(w =>
                    w.Name != null && w.Name.Contains(query, StringComparison.InvariantCultureIgnoreCase)
                )
                .OrderByDescending(o => o.Id)
                .Select(s => s.Name)
                .Distinct()
                .Take(10)
                .ToArray();
        }

        public string[] GetProgrammingLanguagesLikeQuery(string query)
        {
            return _context.ProgrammingLanguages
                .AsEnumerable()
                .Where(w =>
                    w.Name != null && w.Name.Contains(query, StringComparison.InvariantCultureIgnoreCase)
                )
                .OrderByDescending(o => o.Id)
                .Select(s => s.Name)
                .Distinct()
                .Take(10)
                .ToArray();
        }

        public ProgrammingLanguage GetProgrammingLanguageByName(string name)
        {
            return _context.ProgrammingLanguages.FirstOrDefault(f => f.Name == name);
        }

        public Topic GetTopicByName(string topicName)
        {
            return _context.Topics.FirstOrDefault(f => f.Name == topicName);
        }

        public Topic GetTopicById(int id)
        {
            return _context.Topics.FirstOrDefault(f => f.Id == id);
        }

        public void DeleteTopic(Topic topic)
        {
            MoveTasksToGarbageTopic(topic);
            
            var childTopics = _context.Topics.Where(w => w.ParentId == topic.Id);

            foreach (var childTopic in childTopics)
            {
                childTopic.ParentId = null;
                _context.Topics.Update(topic);
            }

            _context.Topics.Remove(topic);
            _context.SaveChanges();
        }

        public ProgrammingTask AddProgrammingTask(ProgrammingTask task)
        {
            var entryEntity = _context.Add(task);
            _context.SaveChanges();

            return entryEntity.Entity;
        }

        public void UpdateProgrammingTask(ProgrammingTask task)
        {
            _context.ProgrammingTasks.Update(task);
            _context.SaveChanges();
        }

        public void DeleteProgrammingTask(ProgrammingTask task)
        {
            _context.ProgrammingTasks.Remove(task);
            _context.SaveChanges();
        }

        public void DeleteImage(Image image)
        {
            _context.Images.Remove(image);
            _context.SaveChanges();
        }

        public void DeleteNestedFile(NestedFile nestedFile)
        {
            _context.NestedFiles.Remove(nestedFile);
            _context.SaveChanges();
        }

        private void MoveTasksToGarbageTopic(Topic topic)
        {
            var tasks = _context
                .ProgrammingTasks
                .Include(i => i.Topic)
                .Where(w => w.Topic.Id == topic.Id);

            if(!tasks.Any())
                return;
            
            var garbageTopicName = "Задачи без темы";
            var garbageTopic = _context.Topics.FirstOrDefault(f => f.Name == garbageTopicName);

            if (garbageTopic == null)
            {
                garbageTopic = new Topic
                {
                    Name = garbageTopicName
                };
                
                _context.Topics.Add(garbageTopic);
            }
            
            foreach (var task in tasks)
            {
                task.Topic = garbageTopic;
                _context.ProgrammingTasks.Update(task);
            }
            
            _context.SaveChanges();
        }
    }
}