using System;
using System.Collections.Generic;
using System.Text;

namespace FullContactClientCore.model
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


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Given name: " + givenName);
            sb.AppendLine("Family name: " + familyName);
            sb.AppendLine("Full name: " + fullName);
            sb.AppendLine("Chats: ----------------------------------------------------------");
            foreach (Chat c in chats)
            {
                sb.AppendLine(c.ToString());
            }
            sb.AppendLine("Websites: ---------------------------------------------------");
            foreach (Website s in websites)
            {
                sb.AppendLine(s.ToString());
            }
            return sb.ToString();
        }
    }
}
