﻿using System;
using System.Text;

namespace JsBHO2
{
    class Log
    {
        private object _logLock = new object();
        const string _fileRoot = "c:\\Logs";

        public void WriteLog(string text)
        {
            lock (_logLock)
            {
                string line = String.Format("[{0:yyyy-MM-dd hh:mm:ss}] {1}\r\n", DateTime.Now, text);
                System.IO.File.AppendAllText(_fileRoot + @"\JsBHO2.txt", line, Encoding.UTF8);//@ 不转义
            }
        }
    }
}
