using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TwitterMessanger : MessangerBase
    {
        public TwitterMessanger(string name, string password) : base(name, password) { }
        public override IMessage SendMessage(string text, string recipient)
        {
            var message = new TwitterMessage(text, recipient);
            return message;
        }
    }
}
