using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class InfinityThread
    {
        private static bool Continue = true;
        public string StringValue { set; get; }
        public int SleepTime { get; set; }

        Thread thread;

        public InfinityThread(string stringValue, int sleepTime)
        {
            StringValue = stringValue;
            SleepTime = sleepTime;

            thread = new Thread(RunThread);
            thread.Start();
        }

        public void RunThread()
        {
            int i = 1;
            while (Continue)
            {
                if (!(i % 10 == 0)) Console.WriteLine($"{i} - {StringValue} - {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                else
                {
                    Console.WriteLine("please enter a number: ");
                    string stringUserNum = Console.ReadLine();
                    if (int.TryParse(stringUserNum, out int NumericValue))
                    {
                        int userNumber = int.Parse(stringUserNum);
                        if (userNumber == 0) Continue = false;
                    }
                }

                Thread.Sleep(SleepTime);
                i++;
            }
        }
    }
}
