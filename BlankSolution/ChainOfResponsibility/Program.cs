using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
            bankPaymentHandler.Successor = paypalPaymentHandler;

            bankPaymentHandler.Handle(receiver);

            Console.Read();
        }
    }
}
