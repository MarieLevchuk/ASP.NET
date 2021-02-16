using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TelegramMessage : MessageBase
    {
        public TelegramMessage(string text, string recipient) : base(text, recipient) { }
        public override void Send()
        {
            //send e-mail in telegram
        }
    }
}
