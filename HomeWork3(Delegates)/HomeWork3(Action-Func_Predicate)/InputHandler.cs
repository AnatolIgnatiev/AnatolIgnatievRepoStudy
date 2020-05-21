using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HomeWork3_Delegates_
{
    public class InputHandler
    {
        public void StartReading(Action<string> transfer)
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
                        transfer?.Invoke(input);
                        break;
                }
            } while (input != "STOP");
        }
    }
}