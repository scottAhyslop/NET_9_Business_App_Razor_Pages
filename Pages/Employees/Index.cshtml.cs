using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_9_Business_App_Razor_Pages.Models;
using NET_9_Business_App_RazorPages.Models;

namespace NET_9_Business_App_Razor_Pages.Pages.Employees
{
    public class EmployeeModel : PageModel //Employee Display page
    {
        #region EmployeeModel

        [BindProperty(SupportsGet = true)]
        public int? EmployeeId { get; set; }
        

        /*public IndexModel(int? employeeId, string? employeeFirstName, string? employeeLastName, string? employeePosition, string? employeeDepartment, double? employeeSalary)
        {
            EmployeeId = employeeId;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeePosition = employeePosition;
            EmployeeDepartment = employeeDepartment;
            EmployeeSalary = employeeSalary;
        }*/


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


