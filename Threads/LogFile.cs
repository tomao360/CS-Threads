using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class LogFile
    {
        private string LogFileName { get; set; }
        private string LogFilePath { get; set; }
        private string LogFileBaseName { get; set; }

        public LogFile(string fileName)
        {
            LogFileName = fileName;
            LogFilePath = Path.GetDirectoryName(fileName);
            LogFileBaseName = Path.GetFileNameWithoutExtension(fileName);
        }

        public void CreateLog(string logType, string messageText)
        {
            CheckFileSize();
            using (StreamWriter sw = new StreamWriter(LogFileName, true))
            {
                sw.WriteLine($"Log {logType} : {DateTime.Now} - {messageText}");
            }
        }

        private void CreateFile()
        {
            int countFileNumber = 1;

            while (System.IO.File.Exists(LogFileName))
            {
                LogFileName = $@"{LogFilePath}\{LogFileBaseName}{countFileNumber}.txt";

                countFileNumber++;
            }

            using (FileStream file = new FileStream(LogFileName, FileMode.Create)) ;
        }

        private void CheckFileSize()
        {

            if (!System.IO.File.Exists(LogFileName))
            {
                using (FileStream file = new FileStream(LogFileName, FileMode.Create)) ;
            }
            else
            {
                FileInfo fileInfo = new FileInfo(LogFileName);
                if (fileInfo.Length >= 1048576)
                {
                    CreateFile();
                }
            }
        }
    }
}
