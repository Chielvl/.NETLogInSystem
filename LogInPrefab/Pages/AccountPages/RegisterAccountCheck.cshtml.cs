using LogInPrefab.Data;
using LogInPrefab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LogInPrefab.Pages
{
    [BindProperties]
    public class RegisterAccountCheckModel : PageModel
    {
        public Account acc { get; set; }
        private readonly ApplicationDbContext _context;

        public RegisterAccountCheckModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(Account account)
        {
            var registeredAcc = _context.Accounts.Where(x => x.AccountName == account.AccountName).FirstOrDefault();
            if (registeredAcc == null)
            {
                _context.Accounts.Add(account);
                _context.SaveChanges();
                return RedirectToPage("ThanksForRegistering");
            }

            return RedirectToPage("RegisterNewAccount", account);
        }
    }
}
