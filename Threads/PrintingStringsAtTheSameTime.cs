using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class PrintingStringsAtTheSameTime
    {
        public int Length { set; get; }
        public string StringValue { set; get; }
        public int SleepTime { get; set; }

        Thread thread;

        public PrintingStringsAtTheSameTime(string stringValue, int sleepTime, int length)
        {
            StringValue = stringValue;
            SleepTime = sleepTime;
            Length = length;
            thread = new Thread(RunThread);
            thread.Start();
        }

        public void RunThread()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"{i} - {StringValue}");
                Thread.Sleep(SleepTime);
            }
        }
    }
}
