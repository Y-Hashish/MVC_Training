using MVC_Training.Models;

namespace MVC_Training.Repositories
{
    public class EmployeeRepo:IEmployee
    {
        ApplicationDbContext context;
        public EmployeeRepo()
        {
            //_context = context;
            context = new ApplicationDbContext();
        }

        public List<Employee> GetAll()
        {
            return context.employees.ToList();
        }
        public void Add(Employee employee)
        {
            context.Add(employee);
        }
        public void Update(int id)
        {
            Employee? employee = context.employees.FirstOrDefault(e => e.id == id);
            context.Update(employee);
        }
        public void Delete(int id )
        {
            Employee emp = GetById(id);
            context.Remove(emp);
            
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public List<Department> GetDept()
        {
            return context.departments.ToList();
        }
        public Employee GetById(int id)
        {
            return context.employees.FirstOrDefault(e => e.id == id);
        }
    }
}
