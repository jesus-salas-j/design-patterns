namespace design_patters.Decorator
{
    public class SupervisedClientDecorator : ClientDecorator
    {
        private readonly string supervisorName;

        public SupervisedClientDecorator(IClient client, string supervisorName)
            : base(client)
        {
            this.supervisorName = supervisorName;
        }

        public override string Info()
        {           
            return base.Info() + $", Supervisor: {supervisorName}";
        }
    }
}
