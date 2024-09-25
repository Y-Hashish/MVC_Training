using Microsoft.EntityFrameworkCore;

namespace MVC_Training.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public ApplicationDbContext():base(){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9856E0J;Initial Catalog=MVC_DB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
