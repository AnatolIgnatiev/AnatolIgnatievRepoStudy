using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        //Вивести в консоль всі парні цифри від 0 до 39
        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                if (number%2 == 0)
                {
                    Console.Write(number + " ");
                }
                number++;
            } while (number <= 39);
            Console.ReadLine();
        }
    }
}
