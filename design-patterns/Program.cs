using System.Threading.Tasks;

namespace design_patters
{
    class Program
    {
        static void Main(string[] args)
        {
            // *********************************************
            // CASE 1: Unsafe multithreading execution
            // *********************************************

            // Parallel execution, only one text is left at the file
            Parallel.Invoke(
              () => Logger.GetInstance().Log("test1"),
              () => Logger.GetInstance().Log("test2")
            );

            // Executing in sequence, both texts are logged to the file
            //Logger.GetInstance().Log("test1");
            //Logger.GetInstance().Log("test2");


            // *********************************************
            // CASE 2: Safe multithreading execution
            // *********************************************

            // Parallel execution, only one text is left at the file
            /*Parallel.Invoke(
              () => ThreadSafeLogger.GetInstance().Log("test1"),
              () => ThreadSafeLogger.GetInstance().Log("test2")
            );*/

            // Executing in sequence, both texts are logged to the file
            //ThreadSafeLogger.GetInstance().Log("test1");
            //ThreadSafeLogger.GetInstance().Log("test2");
        }
    }
}
