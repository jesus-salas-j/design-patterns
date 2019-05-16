using System;

namespace design_patters.Factory
{
    public class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine("Message sent from SmsMessageSender class");
        }
    }
}