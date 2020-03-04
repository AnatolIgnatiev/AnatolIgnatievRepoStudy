using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    class StudentTest/*Написати програму, яка вказуватиме чи допускається студент до екзамену базуючись на наступних критеріях:
                        Математика>=65
                        Фізика>=55
                        Хімія>=50
                        Сума трьох предметів >=180
                        або
                        Сума з математики, і будь-якого іншого предмету>=140
                        Тестові дані : 
                        Фізика :65 
                        Хімія :51 
                        Математика :72
                        Очікуваний результат :
                        Студент допущений.*/
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter points in Math:");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter points in Phisics:");
            int phisics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter points in Chemistry:");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            if (math + phisics + chemistry >= 180 || math + phisics >= 140 || math + chemistry >= 140)
            {
                Console.WriteLine("Student admitted");
            }
            else if (math < 65 || phisics < 55 || chemistry < 50)
            {
                Console.WriteLine("See you next year! )");
            }
            else
            {
                Console.WriteLine("See you next year! )");
            }
            Console.ReadLine();
        }
    }
}
