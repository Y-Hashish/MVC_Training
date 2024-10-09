using System.ComponentModel.DataAnnotations;

namespace MVC_Training.Models
{
    public class UniqeNameAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return null;
            string newName = value.ToString();
            ApplicationDbContext context = new ApplicationDbContext();
            Employee employee = context.employees.FirstOrDefault(e => e.name == newName);
            if (employee != null)
            {
                return new ValidationResult("The name must be uniqe");
            }
            return ValidationResult.Success;
        }
    }
}
