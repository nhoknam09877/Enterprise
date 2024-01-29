using System.ComponentModel.DataAnnotations;

namespace Enterprise.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Department code is required")]
        public string Code { get; set; }

        public string Location { get; set; }

        [Display(Name = "Number of Personnel")]
        public int NumberOfPersonnel { get; set; }

        // Navigation property for employees (one-to-many relationship)
        public ICollection<Employee> ? Employees { get; set; }
    }
}
