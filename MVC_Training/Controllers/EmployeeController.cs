using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using MVC_Training.Models;
using MVC_Training.Repositories;

namespace MVC_Training.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepo emprepo;
        public EmployeeController()
        {
            emprepo = new EmployeeRepo();
        }
        public IActionResult checkName(string name)
        {
            if(name.Contains("slave"))
                return Json(true);
            return Json(false);
        }
        public IActionResult Index()
        {
            List<Employee> employees =emprepo.GetAll();
            //ViewBag.Employees = employees;
            return View("Index", employees);
        }
        

        public IActionResult details (int id)
        {
            var emp = emprepo.GetById(id);
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
                emprepo.Add(emp);
                emprepo.Save();
                return RedirectToAction("Index");
            }
            return View("New",emp);

        }
        public IActionResult edit (int id)
        {
            Employee employee = emprepo.GetById(id);//context.employees.FirstOrDefault(predicate => predicate.id == id);
            var dept = emprepo.GetDept();
            ViewBag.department = dept;
            return View("edit",employee);
        }
        public IActionResult saveEdit(Employee emp, int id )
        {
            if (emp.name != null && emp.salary != null && emp.adress != null && emp.deptId != null && emp.ImageUrl != null)
            {
                var EmpDb = emprepo.GetById(id);//context.employees.FirstOrDefault(p => p.id == id);
                EmpDb.name = emp.name;
                EmpDb.salary = emp.salary;
                EmpDb.adress = emp.adress;
                EmpDb.deptId = emp.deptId;
                EmpDb.ImageUrl = emp.ImageUrl;
                emprepo.Save();
                return RedirectToAction("Index");
            }
            return View("edit",emp);
        }

        public IActionResult delete(int id)
        {
            
            //if (emp != null)
            //{
            //    //context.employees.Remove(emp);

            //    context.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            emprepo.Delete(id);
            return View("index");
            
        }
    }
}
