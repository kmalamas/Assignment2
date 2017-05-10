using FullContactClientCore.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FullContactClientCore
{   /// <summary>
/// Declaration of the IFullContactApi interface, to declare methods for interacting with FullPersonContact API
/// </summary>
    public interface IFullContactApi
    {
        /// <summary>
        /// declaration of LookupPersonByEmailAsync method which accepts email as input and returns an async task of FullContactPerson type
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<FullContactPerson>LookupPersonByEmailAsync(string email);
    }
}
