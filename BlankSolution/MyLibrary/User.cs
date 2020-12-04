using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class User
    {
        private readonly IUser _user;

        public User(IUser user)
        {
            _user = user;
        }

        public string WriteMessage(string message)
        {
            return message;
        }
    }
}
