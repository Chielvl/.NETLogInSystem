using LogInPrefab.Data;
using LogInPrefab.Models;
using Microsoft.AspNetCore.Mvc;

namespace LogInPrefab.Controllers
{
    public class AccountController : Controller
    {
        public static List<Account> Accounts = new List<Account>(){new Account(){AccountName = "dsgt", Password = "EF797C8118F02DFB649607DD5D3F8C7623048C9C063D532CC95C5ED7A898A64F" } };

        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public bool AddedAccountToDatabase(Account account)
        {
            Account registeredAccount = _context.Accounts.FirstOrDefault(x => x.AccountName == account.AccountName);
            if (registeredAccount != null)
            {
                return false;
            }
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return true;
        }


        public bool LogInAccount(Account account)
        {
            Account hit = Accounts.FirstOrDefault(account);
            if(hit != null && hit.Equals(account))
                return true;
                
            return false;
        }
    }
}
