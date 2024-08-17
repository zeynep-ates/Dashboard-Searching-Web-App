using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text.Encodings.Web;

namespace DashboardWebApp2.Pages
{
    public class SearchModel : PageModel
    {
        SearchingClass searchingClass = new SearchingClass();
        public string searchResponseText { get; set; }  
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var choice = Request.Form["choice"];
            
            var userInput = Request.Form["userInput"];

            searchResponseText = string.Empty;

            if (choice.ToString() == "inputID")
            {
                searchResponseText = searchingClass.SearchingID(userInput);
            }
            else
            {
                searchResponseText = searchingClass.SearchingName(userInput);
            }
        }
    }
}
