using System.Runtime.InteropServices;
using LogInPrefab.Controllers;
using LogInPrefab.Data;
using LogInPrefab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogInPrefab.Pages.UserPages
{
    
    public class ThanksForRegisteringModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }

        public void OnGet()
        {

        }
        
    }
}
