using Login.Services;
using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Models
{
    public class IdentityValidator : IIdentityValidator
    {
        public bool UserIsRegistered(User user)
        {
            return (user != null) ? true : false;
        }
    }
}
