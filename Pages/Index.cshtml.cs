using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NET_9_Business_App_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        //points View Engine to the Index.cshtml file, returns page by default
        public void OnGet()//OnGet is equiv of IActionResult in MVC, contains endpoint handler
        { 
            
        }
    }
}
