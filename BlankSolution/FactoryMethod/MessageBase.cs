using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class MessageBase : IMessage
    {
        public string Text { get; set; }
        public string Recipient { get; set; }
        public MessageBase(string text, string recipient)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new Exception("Enter message text");
            }

            if (string.IsNullOrEmpty(recipient))
            {
                throw new Exception("Specify recipient");
            }

            Text = text;
            Recipient = recipient;
        }

        public abstract void Send();
    }
}
