namespace design_patters.Factory
{
    public class MessageSenderFactory
    {
        public static IMessageSender Create(ContactType contactType)
        {
            switch (contactType)
            {
                case ContactType.Whatsapp:
                    return new WhatsappSender();
                case ContactType.Sms:
                    return new SmsSender();
                case ContactType.Email:
                    return new EmailSender();
                default:
                    return new EmailSender();
            }
        }
    }
}