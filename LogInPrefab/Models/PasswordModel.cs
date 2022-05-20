using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace LogInPrefab.Models
{
    public class PasswordModel
    {

        private static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                for (int i = 0; i < 5; i++)
                {
                    inputString = algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString)).ToString();
                }
                
                return Encoding.ASCII.GetBytes(inputString);
            }
                
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
