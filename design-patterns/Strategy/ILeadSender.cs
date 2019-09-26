namespace design_patters.Strategy
{
    public interface ILeadSender
    {
        void Send(Lead lead, string header);
    }
}
