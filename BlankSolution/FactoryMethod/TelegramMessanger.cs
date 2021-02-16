using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TelegramMessanger : MessangerBase
    {
        public TelegramMessanger(string name, string password) : base(name, password) { }
        
        public override IMessage SendMessage(string text, string recipient)
        {
            var message = new TelegramMessage(text, recipient);
            return message;
        }
    }
}
