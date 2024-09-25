using Microsoft.AspNetCore.Mvc;
using MVC_Training.Models;

namespace MVC_Training.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentBL s = new StudentBL();
            List<Student> AllStudents = s.GetAll();
            return View("ShowAll",AllStudents);
        }

        public IActionResult Details (int id)
        {
            StudentBL s = new StudentBL();
            Student student = s.GetById(id);
            return View("Details",student);
        }

    }
}
