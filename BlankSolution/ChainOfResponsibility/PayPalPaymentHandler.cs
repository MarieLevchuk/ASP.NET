using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("PayPal transfer");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
