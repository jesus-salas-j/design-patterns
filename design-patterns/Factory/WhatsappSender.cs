using System;

namespace design_patters.Factory
{
    public class WhatsappSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine("Message sent from WhatsappMessageSender class");
        }
    }
}