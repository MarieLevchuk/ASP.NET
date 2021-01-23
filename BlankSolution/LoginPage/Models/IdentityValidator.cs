using LoginPage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Models
{
    public class IdentityValidator: IIdentityValidator
    {
        public bool UserIsRegistered(User user)
        {
            return (user != null) ? true : false;
        }
    }
}
