using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork8
{
    class Loger
    {
        public void Log(Exception exeption, string logFilePath)
        {
            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Close();
                Console.WriteLine("Log file created");
            }
            File.AppendAllText(logFilePath, exeption.ToString());
        }
    }
}
