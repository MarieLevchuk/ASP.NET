using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IMessanger
    {
        string UserName { get; set; }
        string Password { get; set; }
        IMessage SendMessage(string text, string recipient);
        bool IsConnected { get; }
    }
}
