using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homme_Work_7_Library
{
    public class PrimeNumber
    {
        private static int GetNumber()
        {
            Console.WriteLine("Please enter number you want to check");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input data");
                return number = 0;
            }
            return number;
        }
        public static void CheckPrimeNumber()
        {
            int number = GetNumber();
            bool isPrime = true;
            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
        }
    }
}
