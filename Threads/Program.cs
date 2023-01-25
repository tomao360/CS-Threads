using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Ex1
            //PrintNumber printNumber = new PrintNumber("Hello World!");

            //1-Ex2
            //CreateFile createFile_Ex2 = new CreateFile("ex2", "Hello World!", 1000);

            //1-Ex3+Ex4 => Log File
            //LogFile logFile = new LogFile("D:\\Programming\\Zionet\\Threads\\Threads\\bin\\Debug\\myLog.txt");
            //for (int I = 0; I < 300; I++)
            //{
            //    logFile.CreateLog("Event", "bye");
            //    logFile.CreateLog("Error", "hi");
            //}

            //2-Ex1+Ex2
            //PrintingStringsAtTheSameTime newThread = new PrintingStringsAtTheSameTime("A", 1000, 10);
            //PrintingStringsAtTheSameTime newThread1 = new PrintingStringsAtTheSameTime("B", 1000, 10);

            //PrintingStringsAtTheSameTime newThread2 = new PrintingStringsAtTheSameTime("A", 1000, 100);
            //PrintingStringsAtTheSameTime newThread3 = new PrintingStringsAtTheSameTime("B", 500, 100);
            //PrintingStringsAtTheSameTime newThread4 = new PrintingStringsAtTheSameTime("C", 250, 100);

            //2-Ex3+Ex4
            //RunnerLoopFile runner = new RunnerLoopFile();
            //runner.Run();

            //2-Ex5
            //InfinityThread InfinityThread = new InfinityThread("A", 3000);
            //InfinityThread InfinityThread1 = new InfinityThread("B", 500);

            //2-Ex6
            //ThreadRace threadRace = new ThreadRace();
            //threadRace.MainLoop();

            Console.ReadLine();
        }
    }
}
