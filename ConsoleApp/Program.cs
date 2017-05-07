using Nito.AsyncEx;
using System;
using System.Threading.Tasks;
using FullContactClientCore;
using FullContactClient;

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
            IFullContactApi fullContactApi = new FullContactAPI();
            var  person =await fullContactApi.LookupPersonByEmailAsync(email);
            person.printInfo();
            Console.ReadLine();
           
        }
    }
}