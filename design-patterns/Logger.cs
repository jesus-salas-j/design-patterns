using System;
using System.IO;

namespace design_patters
{
    public class Logger
    {
        private const string PATH = ".";
        private const string FILENAME = "info.log";
        private readonly string PathFile;

        private static Logger _logger;
    
        public static Logger GetInstance()
        {
            if (_logger == null)
            {
                _logger = new Logger();
                Console.WriteLine(DateTime.Now);
            }

            return _logger;
        }

        public void Log(string message)
        {
            using (StreamWriter writer = File.AppendText(PathFile))
            {
                writer.WriteLine(message);
            }
        }

        private Logger()
        {
            PathFile = Path.Combine(PATH, FILENAME);
            File.CreateText(PathFile);
        }
    }
}
