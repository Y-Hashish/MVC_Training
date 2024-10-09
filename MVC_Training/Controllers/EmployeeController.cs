using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using MVC_Training.Models;

namespace MVC_Training.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult checkName(string name)
        {
            if(name.Contains("slave"))
                return Json(true);
            return Json(false);
        }
            ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            List<Employee> employees = context.employees.ToList();
            //ViewBag.Employees = employees;
            return View("Index", employees);
        }
        

        public IActionResult details (int id)
        {
            var emp = context.employees.FirstOrDefault(p => p.id == id);
            return View(emp);
        }
        public IActionResult New()
        {
            return View();
        }
        
        public IActionResult save(Employee emp)
        {
            if (ModelState.IsValid == true)
            {
                context.employees.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New",emp);

        }
        public IActionResult edit (int id)
        {
            Employee employee = context.employees.FirstOrDefault(predicate => predicate.id == id);
            var dept = context.departments.ToList();
            ViewBag.department = dept;
            return View("edit",employee);
        }
        public IActionResult saveEdit(Employee emp, int id )
        {
            if (emp.name != null && emp.salary != null && emp.adress != null && emp.deptId != null && emp.ImageUrl != null)
            {
                var EmpDb = context.employees.FirstOrDefault(p => p.id == id);
                EmpDb.name = emp.name;
                EmpDb.salary = emp.salary;
                EmpDb.adress = emp.adress;
                EmpDb.deptId = emp.deptId;
                EmpDb.ImageUrl = emp.ImageUrl;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("edit",emp);
        }

        public IActionResult delete(int id)
        {
            var emp = context.employees.FirstOrDefault(e =>e.id == id);
            if (emp != null)
            {
                context.employees.Remove(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("index");
            
        }
    }
}
