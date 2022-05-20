using LogInPrefab.Data;
using LogInPrefab.Models;
using LogInPrefab.Pages.UserPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogInPrefab.Pages.AccountPages
{
    [BindProperties]
    public class LogInCheckModel : PageModel
    {
        public Account acc { get; set; }
        private readonly ApplicationDbContext _context;

        public LogInCheckModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(Account account)
        {
            var registeredAcc = _context.Accounts.Where(x => x.AccountName == account.AccountName).FirstOrDefault();
            if (registeredAcc != null && registeredAcc.Password == account.Password)
            {
                return RedirectToPage("LogInSuccessful", account.AccountName);
            }


            return RedirectToPage("LogIn", account);
        }
    }
}
