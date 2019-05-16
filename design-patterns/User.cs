namespace design_patters
{
    public class User
    {
        public string Username { get; }
        public ContactType ContactType { get; }

        public User(string username, ContactType contactType)
        {
            Username = username;
            ContactType = contactType;
        }

        public void Send(string message)
        {
            IMessageSender messageSender = MessageSenderFactory.Create(ContactType);
            messageSender.Send(message);
        }
    }
}
