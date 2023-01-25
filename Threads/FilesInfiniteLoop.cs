using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class RunnerLoopFile
    {
        public void Run()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please enter a file name:");
                FilesInfiniteLoop newFile = new FilesInfiniteLoop(Console.ReadLine(), 500);
            }
        }
    }

    internal class FilesInfiniteLoop
    {      
        public string WriteToFile { get; set; }
        public int SleepTime { get; set; }

        private string _FileName;
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value + ".txt"; }
        }

        public FilesInfiniteLoop(string fileName, int time)
        {
            FileName = fileName;
            SleepTime = time;
            Task.Run(FileExists);
        }

        public void FileExists()
        {
            if (!(File.Exists(FileName)))
            {
                using (FileStream file = new FileStream(FileName, FileMode.Create)) ;
            }
            using (StreamWriter sw = new StreamWriter(FileName, true))
            {
                Random random = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < 5; i++)
                {
                    int randomNum = random.Next(10001);
                    sw.WriteLine(randomNum);
                }
            }

            Thread.Sleep(SleepTime);
        }
    }
}
