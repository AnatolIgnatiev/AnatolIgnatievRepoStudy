using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        /*Написати програму, яка в консолі буде робити такий шаблон, як права частина трикутника і в рядочку будуть однакові числа.
        1
        22
        333
        4444*/
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 4; ++i)
            {
                string output = "";
                for (int numberOfElements = 0; numberOfElements < i; numberOfElements++)
                {
                    output = output + i;
                }
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
