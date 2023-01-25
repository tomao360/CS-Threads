using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class CreateFile
    {
        public string WriteToFile { get; set; }
        public int SleepTime { get; set; }

        private string _FileName;
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value + ".txt"; }
        }

        public CreateFile(string fileName, string writeToFile, int time)
        {
            FileName = fileName;
            SleepTime = time;
            WriteToFile = writeToFile;

            Task.Run(CreatingAndWritingToFile);
        }

        public void CreatingAndWritingToFile()
        {
            if (!(File.Exists(FileName)))
            {
                using (FileStream file = new FileStream(FileName, FileMode.Create)) ;
            }
            using (StreamWriter sw = new StreamWriter(FileName, true))
            {
                sw.WriteLine(WriteToFile);
            }

            Thread.Sleep(SleepTime);
        }
    }
}
