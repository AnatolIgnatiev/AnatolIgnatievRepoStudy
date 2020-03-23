using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homme_Work_7_Library
{
    public class Fibo
    {
        public static int GetNumber()
        {
            Console.WriteLine("Please enter number you want to calculate");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input data");
                return number = 0;
            }
            return number;
        }
        public static int CountFibonachi(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            return CountFibonachi(number - 1) + CountFibonachi(number - 2);
        }
    }
}
