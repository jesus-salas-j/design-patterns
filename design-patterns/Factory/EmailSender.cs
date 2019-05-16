using System;

namespace design_patters.Factory
{
    public class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine("Message sent from EmailMessageSender class");
        }
    }
}