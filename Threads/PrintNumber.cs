using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class PrintNumber
    {
        private readonly string InputString;
        public PrintNumber(string inputString)
        {
            InputString = inputString;
            CreateThread();
        }

        public void CreateThread()
        {
            Thread thread = new Thread(PrintString);
            thread.Start();
        }

        public void PrintString()
        {
            for (int i = 1; i <= 10; i++)
            {
                string line = $"{i}.{InputString}";
                Console.WriteLine(line);
                Thread.Sleep(1000);
            }
        }
    }
}
