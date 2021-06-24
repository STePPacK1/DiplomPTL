using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProgrammingLearningTasks.Database.Entities;
using ProgrammingLearningTasks.Database.Repositories;
using ProgrammingLearningTasks.Models.Identity;

namespace ProgrammingLearningTasks.Controllers
{
    public class IdentityController : Controller
    {
        private readonly UserRepository _repository;

        public IdentityController(UserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel request)
        {
            if (!ModelState.IsValid)
                return View();

            var user = _repository.GetUserByLoginAndPassword(request.Login, request.Password);

            if (user != null)
            {
                await AuthenticateAsync(user);
                return RedirectToAction("Index", "ProgrammingTasks");
            }

            ModelState.AddModelError("Login", "Некорректные логин и(или) пароль");
            ModelState.AddModelError("Password", "Некорректные логином и(или) пароль");

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "ProgrammingTasks");
        }

        [HttpGet]
        [Authorize]
        public IActionResult PersonalArea()
        {
            var userId = GetUserId();
            var user = _repository.GetUserById(userId);

            var userViewModel = new UserViewModel
            {
                FullName = user.FullName,
                Position = user.Position
            };

            return View(userViewModel);
        }

        [HttpPost]
        public IActionResult ChangePassword(UserViewModel viewModel)
        {
            if(viewModel.ChangePasswordNew == null)
                ModelState.AddModelError("ChangePasswordNew", "Поле обязательно для заполнения");
            
            if(viewModel.ChangePasswordConfirm == null)
                ModelState.AddModelError("ChangePasswordConfirm", "Поле обязательно для заполнения");
            
            if (!ModelState.IsValid)
                return View("PersonalArea");

            var userId = GetUserId();
            var user = _repository.GetUserById(userId);

            if (user.Password != viewModel.ChangePasswordConfirm)
            {
                ModelState.AddModelError("ChangePasswordConfirm", "Не верно указан пароль");
                return View("PersonalArea");
            }

            user.Password = viewModel.ChangePasswordNew;
            _repository.Update(user);

            return RedirectToAction("Logout");
        }

        [HttpPost]
        public IActionResult NewUser(UserViewModel viewModel)
        {
            if(viewModel.NewUserFullName == null)
                ModelState.AddModelError("NewUserFullName", "Поле обязательно для заполнения");
            
            if(viewModel.NewUserLogin == null)
                ModelState.AddModelError("NewUserLogin", "Поле обязательно для заполнения");
            
            if(viewModel.NewUserPosition == null)
                ModelState.AddModelError("NewUserPosition", "Поле обязательно для заполнения");
            
            if(viewModel.NewUserPassword == null)
                ModelState.AddModelError("NewUserPassword", "Поле обязательно для заполнения");
            
            if (!ModelState.IsValid)
                return View("PersonalArea");

            var userAtDb = _repository.GetUserByLogin(viewModel.NewUserLogin);

            if (userAtDb != null)
            {
                ModelState.AddModelError("NewUserLogin", "Пользователь с таким логином уже существует");
                return View("PersonalArea");
            }

            var user = new User
            {
                FullName = viewModel.NewUserFullName,
                Login = viewModel.NewUserLogin,
                Position = viewModel.NewUserPosition,
                Password = viewModel.NewUserPassword,
            };

            _repository.Add(user);
            return RedirectToAction("Index", "ProgrammingTasks");
        }

        private async Task AuthenticateAsync(User user)
        {
            var claims = new List<Claim>
            {
                new Claim("uid", user.Id.ToString()),
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.FullName)
            };

            var id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        private int GetUserId()
        {
            var userIdClaim = User.Claims.FirstOrDefault(f => f.Type == "uid");

            var userId = int.Parse(userIdClaim.Value);
            return userId;
        }
    }
}