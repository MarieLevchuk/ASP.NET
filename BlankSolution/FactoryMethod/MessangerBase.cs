using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class MessangerBase : IMessanger
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsConnected { get; }

        public MessangerBase(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                IsConnected = false;
            }
            else
            {
                UserName = userName;
                Password = password;
                IsConnected = true;
            }            
        }

        public abstract IMessage SendMessage(string text, string recipient);
    }
}
