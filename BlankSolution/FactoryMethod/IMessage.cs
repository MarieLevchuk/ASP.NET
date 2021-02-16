using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IMessage
    {
        string Text { get; set; } 
        string Recipient { get; set; }
        void Send();
    }
}
