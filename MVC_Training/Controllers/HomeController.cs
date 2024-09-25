using Microsoft.AspNetCore.Mvc;
using MVC_Training.Models;
using System.Diagnostics;

namespace MVC_Training.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ContentResult TestContent()
        {
            ContentResult result = new ContentResult();
            result.Content = "U merly adopted the dark";
            return result;
        }

        public ViewResult TestView()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "TestView";
            return result;
        }




        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
