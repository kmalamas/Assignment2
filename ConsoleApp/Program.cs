using Nito.AsyncEx;
using System;
using System.Threading.Tasks;
using FullContactClientCore;
using FullContactClient;
using Microsoft.Extensions.Configuration;
using System.IO;

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
            Console.WriteLine("Please enter an email address");
            string email = Console.ReadLine();
            if (!string.IsNullOrEmpty(email)) //TODO add proper input validation for email
            { 
            IFullContactApi fullContactApi = new FullContactAPI();
            var person = await fullContactApi.LookupPersonByEmailAsync(email);
                if (person != null)  //if api returns no data for the email
                {
                    person.printInfo();
                }
                else Console.WriteLine("No data returned for this email address. Press Any key to exit.");
            Console.ReadLine();
            }
           
        }


    }
}