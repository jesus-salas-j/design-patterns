namespace design_patters.Decorator
{
    public sealed class Client : IClient
    {
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; }
        public string PhoneNumber { get; }

        public Client(string name, string surname, string email, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string Info()
        {
            return $@"
                Name: {Name},
                Surname: {Surname},
                Email: {Email},
                Phone number: {PhoneNumber}";
        }
    }
}
