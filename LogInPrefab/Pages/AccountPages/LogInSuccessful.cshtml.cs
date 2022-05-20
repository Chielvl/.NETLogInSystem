using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogInPrefab.Pages.UserPages
{
    
    public class LogInSuccessful : PageModel
    {
        [BindProperty]
        public string AccountName { get; set; }
        public void OnGet(string AccountName)
        {
            this.AccountName = AccountName;
        }
    }
}
