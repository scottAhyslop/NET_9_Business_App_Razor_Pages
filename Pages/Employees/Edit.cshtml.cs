using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace NET_9_Business_App_Razor_Pages.Pages
{

    public class EmployeesModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? EmployeeId { get; set; }

        [BindProperty]
        public InputModel? Employee { get; set; }

        public class InputModel
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

        public void OnGet()
        {
        }

        public void OnPostSave()
        {
            if (!ModelState.IsValid)
            {
                this.Employee!.ErrorMessages = ShowErrors();
            }
            //do something when the state is valid
        }

        public void OnPostDelete()
        {
            
        }
        //Error display method
        private List<string> ShowErrors() 
        { 
            List<string> errorMessages = new List<string>();
            foreach (var value in ModelState.Values)
            {
                foreach (var error in value.Errors)
                {
                    errorMessages.Add(error.ErrorMessage);  
                }
            }
            return errorMessages;
        }//end ShowErrors

    }
}
