using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class Plan
    {
        public string Day;
        public string Event;
    }
    class HomeWork6
    {
        public static Plan[] GetPlans(string[][] input)
        {
            Plan[] result = new Plan[input.Length];
            int indexer = 0;
            foreach (var item in input)
            {
                result[indexer] = new Plan();
                int dayNumber = 0;
                if (item.Length != 2 || !int.TryParse(item[1], out dayNumber) || string.IsNullOrEmpty(item[0]))
                {
                    Console.WriteLine("Invalid input data!");
                    return result = null;
                }
                result[indexer].Event = item[0].ToLower();
                /* В другій позиції масиву цифру заміняти за наступним принципом: 1 - monday,...7- sunday*/
                switch (dayNumber)
                {
                    case 1:
                        result[indexer].Day = "monday";
                        break;
                    case 2:
                        result[indexer].Day = "tuesday";
                        break;
                    case 3:
                        result[indexer].Day = "wednesday";
                        break;
                    case 4:
                        result[indexer].Day = "thursday";
                        break;
                    case 5:
                        result[indexer].Day = "friday";
                        break;
                    case 6:
                        result[indexer].Day = "saturday";
                        break;
                    case 7:
                        result[indexer].Day = "sunday";
                        break;
                }
                indexer++;
            }
            return result;
        }
        // Вивести кожен елемент масиву в консоль в наступному форматі "{подія} on {день}”
        // Якщо в стрічці більше 10 символів, то обрізати перших десять і вставити ... Всі літери мають бути маленькими
        public static void ShowPlans(Plan[] plans)
        {
            foreach (var plan in plans)
            {
                string outputString = plan.Event + " on " + plan.Day;
                if (outputString.Length > 10)
                {
                    Console.WriteLine("..." + outputString.Substring(10));
                }
            }
        }
        static void Main(string[] args)
        {
            string[][] input = new string[][]
            {
                new string []{"John and Mary have a discussion","1"},
                new string []{"John and Mary interview","3"},
                new string []{"F2F","4"},
                new string []{"General meeting","7"}
            };
            ShowPlans(GetPlans(input));
            Console.ReadLine();
        }
    }
}
