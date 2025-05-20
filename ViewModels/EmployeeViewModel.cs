using System.ComponentModel.DataAnnotations;

namespace NET_9_Business_App_Razor_Pages.ViewModels
{
    public class EmployeeViewModel
    {
        public int? EmployeeId { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string? EmployeeFirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string? EmployeeLastName { get; set; }
        public string? EmployeePosition { get; set; }
        public string? EmployeeDepartment { get; set; }
        public double? EmployeeSalary { get; set; }
        public List<string>? ErrorMessages { get; set; }
    }
}
