using System;
using System.Collections.Generic;
using System.Text;

namespace FullContactClient.model
{
    public class Person
    {

            public string likelihood { get; set; }
            public ContactInfo contactInfo { get; set; }
            public IEnumerable<SocialProfile> socialProfiles { get; set; }




        public void printInfo()
            {
                Console.WriteLine("Likelihood: " + likelihood);
                contactInfo.print();
                Console.WriteLine("Social Profiles: ");
                foreach (SocialProfile p in socialProfiles)
                {
                    p.printProfile();
                }
            }
        }
    }

