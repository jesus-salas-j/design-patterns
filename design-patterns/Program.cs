using System;
using System.Threading.Tasks;
using design_patters.Builder;
using design_patters.Decorator;
using design_patters.Factory;

namespace design_patters
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***************************************************************
            // SINGLETON PATTERN CASE 1: Unsafe multithreading execution
            // ***************************************************************

            // Parallel execution, only one text is left at the file
            /*Parallel.Invoke(
              () => Logger.GetInstance().Log("test1"),
              () => Logger.GetInstance().Log("test2")
            );*/

            // Executing in sequence, both texts are logged to the file
            //Logger.GetInstance().Log("test1");
            //Logger.GetInstance().Log("test2");


            // ***************************************************************
            // SINGLETON PATTERN CASE 2: Safe multithreading execution
            // ***************************************************************

            // Parallel execution, only one text is left at the file
            /*Parallel.Invoke(
              () => ThreadSafeLogger.GetInstance().Log("test1"),
              () => ThreadSafeLogger.GetInstance().Log("test2")
            );*/

            // Executing in sequence, both texts are logged to the file
            //ThreadSafeLogger.GetInstance().Log("test1");
            //ThreadSafeLogger.GetInstance().Log("test2");


            // ***************************************************************
            // FACTORY PATTERN
            // ***************************************************************

            MessagingService messagingService = new MessagingService();
            messagingService.sendMessageTo(new User
            {
                ContactType = ContactType.Whatsapp
            }, "hello");


            // ***************************************************************
            // BUILDER PATTERN
            // ***************************************************************
            /*
            Ad ad = new Ad.AdBuilder()
                .WithPrice(150000)
                .WithAddress("Main Street, 152")
                .WithContactEmail("test@domain.com")
                .WithSquareMeters(100)
                .Build();
            */


            // ***************************************************************
            // DECORATOR PATTERN
            // ***************************************************************

            IClient client = new Client(
                name: "Jesús",
                surname: "S",
                email: "example@gmail.com",
                phoneNumber: "11111111"
            );

            SupervisedClientDecorator clientDecorator = new SupervisedClientDecorator(client, "Juan");
            Console.Out.WriteLine(clientDecorator.Info());
        }
    }
}
