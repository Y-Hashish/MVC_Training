using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Training.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string adress { get; set; }
        public string ImageUrl { get; set; }
        public int deptId { get; set; }
        [ForeignKey("deptId")]
        public Department department { get; set; }
    }
}
