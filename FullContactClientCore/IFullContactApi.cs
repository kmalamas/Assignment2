using FullContactClientCore.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FullContactClientCore
{
    public interface IFullContactApi
    {
        Task<FullContactPerson>LookupPersonByEmailAsync(string email);
    }
}
