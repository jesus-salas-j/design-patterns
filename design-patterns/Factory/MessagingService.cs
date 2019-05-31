namespace design_patters.Factory
{
    public class MessagingService
    {
        public void sendMessageTo(User user, string message)
        {
            IMessageSender messageSender = MessageSenderFactory.Create(user.ContactType);
            messageSender.Send(message);
        }
    }
}
