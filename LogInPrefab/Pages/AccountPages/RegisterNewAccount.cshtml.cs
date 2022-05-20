using LogInPrefab.Controllers;
using LogInPrefab.Data;
using LogInPrefab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogInPrefab.Pages
{

    [BindProperties]
    public class RegisterNewAccountModel : PageModel
    {

        public Account Account { get; set; }
        public string errorMessage { get; set; } = string.Empty;

        public void OnGet(Account acc)
        {
            if (acc.AccountName == null)
            {
                Account = new Account() ;
            }
            else
            {
                Account = acc;
                errorMessage = "Username is taken, please pick another";
            }
            
        }
        
        public IActionResult OnPost()
        {
            string password = Request.Form["password"];
            Account.Password = PasswordModel.GetHashString(password);
            return RedirectToPage("RegisterAccountCheck", Account);

        }
    }

}
