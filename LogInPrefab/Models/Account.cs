using System.ComponentModel.DataAnnotations;

namespace LogInPrefab.Models;
public class Account
{
    public int Id { get; set; }
    public string? AccountName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    [Required(ErrorMessage = "An email address is required")]
    [RegularExpression(@"(^[\w]+|[(!#$%&'\*\+\-\/\\=?^_`,:;<>[{}()\]]{0,1}[\w$]+){1,64}@[\w\-\.]+\.[a-zA-Z]{0,}\.{0,1}[a-zA-Z]{2,}")]
    public string Email { get; set; }
    public string Password { get; set; }


    public bool Equals(Account account)
    {
        if (account == null)
        {
            return false;
        }
        else if (account.AccountName.Equals(this.AccountName) && account.Password.Equals(this.Password))
        {
            return true;
        }

        return false;
    }
}
