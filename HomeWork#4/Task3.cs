using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3
    {
        // Вивести в консоль значення від 10 до 0, без цифри 5, використовуючи цикл for
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
