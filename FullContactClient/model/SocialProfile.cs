using System;
using System.Collections.Generic;
using System.Text;

namespace FullContactClient.model
{
    public class SocialProfile
    {
        public string bio { get; set; }
        public string followers { get; set; }
        public string following { get; set; }
        public string type { get; set; }
        public string typeId { get; set; }
        public string typeName { get; set; }
        public string url { get; set; }
        public string username { get; set; }
        public string id { get; set; }

        public void printProfile()
        {
            Console.WriteLine(typeName + " Profile :");
            Console.WriteLine("Username :" + username);
            if (bio != null) { Console.WriteLine("Bio :" + bio); }
            Console.WriteLine("Url :" + url);
            if (id != null) { Console.WriteLine("User ID :" + id); }
            Console.WriteLine("Type  :" + type);
            Console.WriteLine("Type ID :" + typeId);
            if (followers != null) { Console.WriteLine("Followers :" + followers); }
            if (following != null) { Console.WriteLine("following :" + following); }

        }
    }
}
