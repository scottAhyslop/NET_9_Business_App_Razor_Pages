using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_9_Business_App_MVC.Models;

namespace NET_9_Business_App_Razor_Pages.Pages.Employees
{
    public class IndexModel : PageModel //Employee Display page
    {
        #region EmployeeModel

        [BindProperty(SupportsGet = true)]
        public int EmployeeId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? EmployeeFirstName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? EmployeeLastName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? EmployeePosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? EmployeeDepartment { get; set; }
        [BindProperty(SupportsGet = true)]
        public double? EmployeeSalary { get; set; }

        public IndexModel(int employeeId, string employeeFirstName, string employeeLastName, string employeePosition, string employeeDepartment, double employeeSalary)
        {
            EmployeeId = employeeId;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeePosition = employeePosition;
            EmployeeDepartment = employeeDepartment;
            EmployeeSalary = employeeSalary;
        }


        #endregion

        #region Sample Data
        //Sample data for the Employee Model
        private List<Employee> employees = new List<Employee>
            {
            new Employee(1,"Ozzy","Osbourne", "Membranophone Specialist","Vocals", 500000),
            new Employee(2,"Tony", "Iommi", "Guitar Player", "Guitars", 500000),
            new Employee(3,"Geezer", "Butler", "Bass Player", "Guitars", 500000),
            new Employee(4,"Bill", "Ward", "Bongos", "Percussion", 500000),
            };

        #endregion

        public void OnGet()
        { 
        
        }

        
    
    }//end PageModel
}//end namespace


