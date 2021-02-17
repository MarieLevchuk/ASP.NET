using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine(" bank transfer");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
