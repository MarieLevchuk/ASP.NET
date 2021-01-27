using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Services
{
    public interface IIdentityValidator
    {
        public bool UserIsRegistered(User user);
    }
}
