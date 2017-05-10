using System;
using System.Collections.Generic;
using System.Text;

namespace FullContactClientCore.model
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(typeName + " Profile :");
            sb.AppendLine("Username :" + username);
            if (bio != null) { sb.AppendLine("Bio :" + bio); }
            sb.AppendLine("Url :" + url);
            if (id != null) { sb.AppendLine("User ID :" + id); }
            sb.AppendLine("Type  :" + type);
            sb.AppendLine("Type ID :" + typeId);
            if (followers != null) { sb.AppendLine("Followers :" + followers); }
            if (following != null) { sb.AppendLine("following :" + following); }
            return sb.ToString();

        }
    }
}
