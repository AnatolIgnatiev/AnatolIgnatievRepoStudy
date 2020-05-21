using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HomeWork3_Delegates_
{
    public delegate void Transfer(string inputString);
    public class InputHandler
    {
        public event Transfer GotString;
       
        public void StartReading()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "STOP":
                        break;
                    default:
                        GotString?.Invoke(input);
                        break;
                }
            } while (input != "STOP");
        }
    }
}