using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Receiver
    {
        public bool BankTransfer { get; set; }
        public bool PayPalTransfer { get; set; }
        public Receiver(bool bankTransfer, bool payPalTransfer)
        {
            BankTransfer = bankTransfer;
            PayPalTransfer = payPalTransfer;
        }
    }
}
