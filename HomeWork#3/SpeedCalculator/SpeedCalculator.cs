using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCalculator
{
    class SpeedCalculator
        //Написати програму, яка приймає на вхід відстань і час і показує швидкість у милях за год, метрах за секунду і кілометрах за годину.Тестові дані:
        //Input distance(meters): 50000 
        //Input timeSec(hour): 1 
        //Input timeSec(minutes): 35
        //Input timeSec(seconds): 56
        //Очікуваний результат
        //Your speed in meters/sec is 8.686588
        //Your speed in km/h is 31.27172 
        //Your speed in miles/h is 19.4355
    {
        static void Main(string[] args)
        {
            double distance;
            double timeHours;
            double timeMinutes;
            double timeSeconds;
            Console.WriteLine("Please enter distance (in meters):");
            bool distanceIsDigit = double.TryParse(Console.ReadLine(), out distance);
            Console.WriteLine("Please enter time (in hours):");
            bool timeHoursIsDigit = double.TryParse(Console.ReadLine(), out timeHours);
            Console.WriteLine("Please enter time (in minuts):");
            bool timeMinutesIsDigit = double.TryParse(Console.ReadLine(), out timeMinutes);
            Console.WriteLine("Please enter time (in seconds):");
            bool timeSecondsIsDigit = double.TryParse(Console.ReadLine(), out timeSeconds);
            if (!distanceIsDigit || !timeHoursIsDigit || !timeMinutesIsDigit || !timeSecondsIsDigit) // check if input are digits
            {
                Console.WriteLine("Sorry, all input data must be a digits.");
                Console.ReadLine();
                return;
            }
            double totalTimeInSeconds = (timeHours * 60 * 60) + (timeMinutes * 60) + timeSeconds;
            double metersPerSecond = distance / totalTimeInSeconds; // meters/sec
            double kilometersPerHours = distance / 1000 / (totalTimeInSeconds / 60 / 60); // (meters / 1000 = km) / (seconds * 60 * 60 = h)
            double milesPerHours = (distance * 0.00062137) / (totalTimeInSeconds / 60 / 60); // (meters * 0.00062137 = miles) / (seconds * 60 * 60 = h)
            Console.WriteLine("Your speed in meters/sec is {0:F6}",metersPerSecond ); 
            Console.WriteLine("Your speed in km/h is {0:F5}", kilometersPerHours); 
            Console.WriteLine("Your speed in miles/h is {0:F4}", milesPerHours); 
            Console.ReadLine();
        }
    }
}
