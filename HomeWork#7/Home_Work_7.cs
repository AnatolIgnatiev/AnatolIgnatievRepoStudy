using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homme_Work_7_Library;

namespace Home_Work_6
{
    class Home_Work_7
    {
        static void Main(string[] args)
        {
            PrimeNumber.CheckPrimeNumber();
            Console.WriteLine(Fibo.CountFibonachi(Fibo.GetNumber()));
            Console.ReadKey();
        }
    }
}
