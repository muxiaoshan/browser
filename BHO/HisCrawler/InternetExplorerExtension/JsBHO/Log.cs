using System;
using System.Text;

namespace JsBHO
{
    class Log
    {
        private object _logLock = new object();
        const string _fileRoot = "c:\\Logs";
        string fileName;
        public Log()
        {
            this.fileName = "JsBHO.txt";
        }
        public Log(string fileName)
        {
            this.fileName = fileName;
        }

        public void WriteLog(string text)
        {
            lock (_logLock)
            {
                string line = String.Format("[{0:yyyy-MM-dd hh:mm:ss}] {1}\r\n", DateTime.Now, text);
                System.IO.File.AppendAllText(_fileRoot + @"\" + fileName, line, Encoding.UTF8);//@ 不转义
            }
        }
    }
}
