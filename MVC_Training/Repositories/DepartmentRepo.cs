using MVC_Training.Models;

namespace MVC_Training.Repositories
{
    public class DepartmentRepo:IDepartment
    {
        ApplicationDbContext _context;
        public DepartmentRepo(ApplicationDbContext context)
        {
            //_context = context;
            _context = new ApplicationDbContext();
        }

    }
}
