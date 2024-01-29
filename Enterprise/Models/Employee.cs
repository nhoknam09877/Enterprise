using System.ComponentModel.DataAnnotations;

namespace Enterprise.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee name is required")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Employee code is required")]
        public string  EmployeeCode { get; set; }


        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department  ? Department { get; set; }

        public string   Rank { get; set; }
    }
}
