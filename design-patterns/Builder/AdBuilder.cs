using System;
namespace design_patters.Builder
{
    public class Ad
    {
        public Guid Id { get; }
        public int Price { get; }
        public TransactionType Transaction { get; }
        public int SquareMeters { get; }
        public string Address { get; }
        public string ContactPhoneNumber { get; }
        public string ContactEmail { get; }
        public int RoomsNumber { get; }
        public int BathroomsNumber { get; }

        internal Ad(int price, TransactionType transaction, int squareMeters,
            string address, string contactPhoneNumber, string contactEmail,
            int roomsNumber, int bathroomsNumber)
        {
            Id = Guid.NewGuid();
            Price = price;
            Transaction = transaction;
            SquareMeters = squareMeters;
            Address = address;
            ContactPhoneNumber = contactPhoneNumber;
            ContactEmail = contactEmail;
            RoomsNumber = roomsNumber;
            BathroomsNumber = bathroomsNumber;
        }

        public class AdBuilder
        {
            private int Price;
            private TransactionType Transaction;
            private int SquareMeters;
            private string Address;
            private string ContactPhoneNumber;
            private string ContactEmail;
            private int RoomsNumber;
            private int BathroomsNumber;

            public AdBuilder WithPrice(int price)
            {
                Price = price;
                return this;
            }

            public AdBuilder WithTransactionType(TransactionType transactionType)
            {
                Transaction = transactionType;
                return this;
            }

            public AdBuilder WithSquareMeters(int squareMeters)
            {
                SquareMeters = squareMeters;
                return this;
            }

            public AdBuilder WithAddress(string address)
            {
                Address = address;
                return this;
            }

            public AdBuilder WithContactPhoneNumber(string phoneNumber)
            {
                ContactPhoneNumber = phoneNumber;
                return this;
            }

            public AdBuilder WithContactEmail(string email)
            {
                ContactEmail = email;
                return this;
            }

            public AdBuilder WithRoomsNumber(int roomsNumber)
            {
                RoomsNumber = roomsNumber;
                return this;
            }

            public AdBuilder WithBathroomsNumber(int bathroomsNumber)
            {
                BathroomsNumber = bathroomsNumber;
                return this;
            }

            public Ad Build()
            {
                return new Ad(Price, Transaction, SquareMeters, Address, ContactPhoneNumber,
                    ContactEmail, RoomsNumber, BathroomsNumber);
            }
        }
    }

}
