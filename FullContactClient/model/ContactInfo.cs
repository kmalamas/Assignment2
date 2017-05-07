using System;
using System.Collections.Generic;
using System.Text;

namespace FullContactClient.model
{
    public class ContactInfo
    {
        public struct Chat
        {
            public string client;
            public string handle;
            public Chat(string client, string handle)
            {
                this.client = client;
                this.handle = handle;
            }
            public override string ToString()
            {
                return "client: " + client + "\n" + "handle: " + handle;

            }

        }
        public struct Website
        {
            public string url;

            public Website(string url) { this.url = url; }
            public override string ToString()
            {
                return "url :" + url;
            }

        }
        public IEnumerable<Chat> chats { get; set; }
        public IEnumerable<Website> websites { get; set; }
        public string givenName { get; set; }
        public string familyName { get; set; }
        public string fullName { get; set; }
        public void print()
        {
            Console.WriteLine("Given name: " + givenName);
            Console.WriteLine("Family name: " + familyName);
            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Chats: ");
            foreach (Chat c in chats)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("Websites: ");
            foreach (Website s in websites)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
