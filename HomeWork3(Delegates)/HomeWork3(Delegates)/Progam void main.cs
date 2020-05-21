using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Delegates_
{
    public class Progam_void_main
    {
        private static List<ICollector> collectors = new List<ICollector>() { new AlphaNumbericCollector(), new StringCollector() };
        public static void Main()
        {
            InputHandler inputHandler = new InputHandler();
            
            inputHandler.StartReading(TransferString);

            foreach (var collector in collectors)
            {
                foreach (var item in collector.GetSaved())
                {
                    Console.WriteLine($"{collector.GetType()} saved - {item}");
                }
            }

            Console.ReadLine();
        }
        private static void TransferString(string someString)
        {
            foreach (var collector in collectors)
            {
                collector.Save(someString);
            }
        }
    }
}
