using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProgrammingLearningTasks.Models;

namespace ProgrammingLearningTasks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult NotAccess()
        {
            return View();
        }
        
        public IActionResult PageNotFound()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}