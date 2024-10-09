using Microsoft.AspNetCore.Mvc;

namespace MVC_Training.Controllers
{
    public class StateController : Controller
    {
        public IActionResult SetSession(string name)
        {
            HttpContext.Session.SetString("name", name);
            HttpContext.Session.SetInt32("age", 21);
            return Content("session saved sucessfully");
        }
        public IActionResult GetSession()
        {
            string? n = HttpContext.Session.GetString("name");
            int? a = HttpContext.Session.GetInt32("age");
            return Content($"{n} {a}");
        }
        public IActionResult SetCookie()
        {
            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Response.Cookies.Append("name", "Ghost");
            HttpContext.Response.Cookies.Append("age", "21",cookie);
            return Content("Cookies Saved");
        }
        public IActionResult GetCookie()
        {
            string? n = HttpContext.Request.Cookies["name"];
            string? a = HttpContext.Request.Cookies["age"];
            return Content($"{n} : {a}");
        }
    }
}
