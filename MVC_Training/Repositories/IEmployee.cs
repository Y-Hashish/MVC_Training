using MVC_Training.Models;

namespace MVC_Training.Repositories
{
    public interface IEmployee
    {
        public List<Employee> GetAll();

        public void Add(Employee employee);

        public void Update(int id);

        public void Delete(int id);
        public Employee GetById(int id);
        public List<Department> GetDept();

        public void Save();
       
    }
}
