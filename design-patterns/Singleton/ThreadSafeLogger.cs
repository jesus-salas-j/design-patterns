using System;
using System.IO;

namespace design_patters
{
    public class ThreadSafeLogger
    {
        private const string PATH = ".";
        private const string FILENAME = "info.log";
        private readonly string PathFile;
        private int LineNumber = 1;

        private static ThreadSafeLogger Logger;
        private static readonly object InstanceLock = new object();

        public static ThreadSafeLogger GetInstance()
        {
            if (Logger == null)
            {
                lock (InstanceLock)
                {
                    if (Logger == null)
                    {
                        Logger = new ThreadSafeLogger();
                        Console.WriteLine(DateTime.Now);
                    }
                }
            }

            return Logger;
        }

        public void Log(string message)
        {
            using (StreamWriter writer = File.AppendText(PathFile))
            {
                writer.WriteLine($"{LineNumber} message");
            }

            LineNumber++;
        }

        private ThreadSafeLogger()
        {
            PathFile = Path.Combine(PATH, FILENAME);
            File.CreateText(PathFile);
        }
    }
}
