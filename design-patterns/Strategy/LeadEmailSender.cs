using System;

namespace design_patters.Strategy
{
    public class LeadEmailSender : ILeadSender
    {
        public void Send(Lead lead, string header)
        {
            Console.Out.WriteLine($"{header} Lead sent by email.");
        }
    }
}
