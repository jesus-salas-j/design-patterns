using System;

namespace design_patters.Strategy
{
    public class LeadSmsSender : ILeadSender
    {
        public void Send(Lead lead, string header)
        {
            Console.Out.WriteLine($"{header} Lead sent by Sms.");
        }
    }
}
