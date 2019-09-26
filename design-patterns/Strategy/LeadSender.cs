namespace design_patters.Strategy
{
    public class LeadSender
    {
        private ILeadSender leadSender;

        public LeadSender(ILeadSender leadSender)
        {
            this.leadSender = leadSender;
        }

        public void Send(Lead lead)
        {
            string header = BuildMessageHeader(lead);
            leadSender.Send(lead, header);
        }

        private string BuildMessageHeader(Lead lead)
        {
            // TODO: implement message header generation
            return "";
        }
    }
}
