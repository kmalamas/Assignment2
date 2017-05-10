using Nito.AsyncEx;
using System;
using System.Threading.Tasks;
using FullContactClientCore;
using FullContactClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
   
    class Program
    {
        public static void Main(string[] args)
        {
            AsyncContext.Run(() => AsyncMain());
        }

        static async Task AsyncMain()
        {
            bool validInput = true;
            string email = string.Empty;
            Console.WriteLine("Please enter an email address");
            while (validInput)
            {
               
                email = Console.ReadLine();
                if (!string.IsNullOrEmpty(email) && IsValidEmail(email)) 
                    validInput = false;
                else Console.WriteLine("Please enter a valid email address.");
            }

            IFullContactApi fullContactApi = new FullContactAPI();
            var person = await fullContactApi.LookupPersonByEmailAsync(email);
                if (person != null)  //if api returns no data for the email
                {
                    person.printInfo();
                }
                else Console.WriteLine("No data returned for this email address. Press Any key to exit.");
            Console.ReadLine();

           
        }

       static  bool IsValidEmail(string email)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}