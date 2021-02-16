using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TwitterMessage : MessageBase
    {
        public TwitterMessage(string text, string recipient) : base(text, recipient)
        {
            int maxMessageLength = 140;
            if (text.Length <= maxMessageLength)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, maxMessageLength);
            }
        }
        public override void Send()
        {
            //send e-mail in twitter
        }
    }
}
