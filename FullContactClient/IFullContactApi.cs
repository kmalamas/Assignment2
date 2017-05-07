using FullContactClient.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FullContactClient
{
    interface IFullContactApi
    {
        Task<FullContactPerson>LookupPersonByEmailAsync(string email);
    }
}
