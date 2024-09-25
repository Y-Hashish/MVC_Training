using Microsoft.AspNetCore.Mvc;

namespace MVC_Training.Controllers
{
    public class HelloWorldController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
