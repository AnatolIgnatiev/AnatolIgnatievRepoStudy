using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Multiply // Написати програму, яка зупускатися в консолі. При запуску має написати користувачеві повідомлення 
                   //  “I wanna calculate something for you, please input the first digit” і очікує вводу цифри. 
                   //  Після вводу першої цифри, програма виводить наступне повідомлення:  ”Thank’s and another digit please!”. 
                   //  Після вводу програма повинна вивести результат множення в такому форматі: “Here you are: {результат} :).” 
                   //  Якщо ж будь-яке з введених чисел є не числом, то програма має вивести повідомлення :”Sorry, I do not now how to multiply chars :(.”, 
                   //  почекати поки користувач натисне будь-яку кнопку і завершити роботу. 
                   //  Якщо будь-яка цифра є більшою за 10 чи меншою за 0, то програма має вивести повідомлення :
                   //  ”Sorry, I support only digits from 0 to 10 :(”, почекати поки користувач натисне будь-яку кнопку і завершити роботу.
    {
        static void Main(string[] args)
        {
            int firstDigit;
            int secondDigit;
            Console.WriteLine("I wanna calculate something for you, please input the first digit");
            bool firstIsDigit = int.TryParse(Console.ReadLine(), out firstDigit);
            
            Console.WriteLine("Thank’s and another digit please!");
            bool secondIsDigit = int.TryParse(Console.ReadLine(), out secondDigit);
            
            if (!firstIsDigit || !secondIsDigit) // check if input are digits
            {
                Console.WriteLine("Sorry, I do not now how to multiply chars :(.");
                Console.ReadLine();
            }
            else if (firstDigit > 10 || firstDigit < 0 || secondDigit > 10 || secondDigit < 0) // check if input digits are in range between 0 and 10
            {
                Console.WriteLine("Sorry, I support only digits from 0 to 10 :(");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Here you are: {firstDigit * secondDigit} :).");
            }
        }
    }
}
