namespace design_patters.Decorator
{
    public abstract class ClientDecorator : IClient
    {
        private readonly IClient client;

        public ClientDecorator(IClient client)
        {
            this.client = client;
        }

        public virtual string Info()
        {
            return client.Info();
        }
    }
}
