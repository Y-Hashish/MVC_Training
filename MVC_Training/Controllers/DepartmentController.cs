using Microsoft.AspNetCore.Mvc;
using MVC_Training.Models;

namespace MVC_Training.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            ViewData["data"] = context.departments.ToList();
            ViewBag.name = "Hashish Lite";

            return View("index");
        }
    }
}
