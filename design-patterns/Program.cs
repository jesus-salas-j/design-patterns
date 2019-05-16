using System.Threading.Tasks;
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

            //IMessageSender sender = MessageSenderFactory.Create(ContactType.Sms);
            //sender.Send("test");
        }
    }
}
