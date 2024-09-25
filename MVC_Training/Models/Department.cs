namespace MVC_Training.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? manger { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
