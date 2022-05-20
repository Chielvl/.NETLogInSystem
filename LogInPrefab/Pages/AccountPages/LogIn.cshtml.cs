using System.Security.Claims;
using LogInPrefab.Controllers;
using LogInPrefab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogInPrefab.Pages.AccountPages
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public Account Account { get; set; }
        public string errorMessage = string.Empty;


        public void OnGet(Account acc)
        {
            if (acc.AccountName == null)
            {
                Account = new Account();
            }
            else
            {
                Account = acc;
                errorMessage = "Username is taken, please pick another";
            }


        }
        public IActionResult OnPost()
        {
            Account.AccountName = Request.Form["userName"];
            string pass = Request.Form["password"];
            Account.Password = PasswordModel.GetHashString(pass);

            return RedirectToPage("LogInCheck", Account);



        }
    }
}
