using Microsoft.AspNetCore.Mvc;

namespace NET_9_Business_App_Razor_Pages.Pages.Components.EmployeeComponent
{
    [ViewComponent(Name = "EmployeeViewComponent")]
    public class EmployeeViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke(string message)
        {
            // You can pass data to the view using ViewData
            ViewData["message"] = $"Your message is {message}";
            return View();
        }
    }
}
