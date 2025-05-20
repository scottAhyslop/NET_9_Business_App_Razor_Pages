using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_9_Business_App_Razor_Pages.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace NET_9_Business_App_Razor_Pages.Pages
{

    public class EditModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? EmployeeId { get; set; }

        [BindProperty]
        public EmployeeViewModel? EmployeeViewModel { get; set; }

        

        public void OnGet(int EmployeeId)
        {
            this.EmployeeViewModel = new EmployeeViewModel();
            //this.EmployeeViewModel.Empl
        }

        public IActionResult OnPostSave()
        {
            if (!ModelState.IsValid)
            {
                this.EmployeeViewModel!.ErrorMessages = ShowErrors();
                return Page();
            }
            //do something when the state is valid
            return RedirectToPage("Index");
        }

        public IActionResult OnPostDelete()
        {
            return RedirectToPage("Index");
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
