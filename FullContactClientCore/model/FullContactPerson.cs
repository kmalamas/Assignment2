using System;
using System.Collections.Generic;
using System.Text;

namespace FullContactClientCore.model
{
    public class FullContactPerson
    {

            public string likelihood { get; set; }
            public ContactInfo contactInfo { get; set; }
            public IEnumerable<SocialProfile> socialProfiles { get; set; }




             public override string ToString()
             {

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Likelihood: " + likelihood);
                sb.AppendLine(contactInfo.ToString());
                sb.AppendLine("Social Profiles: --------------------------------------");
                foreach (SocialProfile p in socialProfiles)
                {
                sb.AppendLine(p.ToString());
                }
            return sb.ToString();
             }
        }
    }

