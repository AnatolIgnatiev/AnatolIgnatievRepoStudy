using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork4_LINQ_
{
    public class Time
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
    public class Player
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*На вхід є стрічка "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana,
              Rodriguez, Lambert" Кожному гравцеві надайте номер, починаючи з 1, щоб вийшла стрічка
              подібна : "1. Davis, 2. Clyne, 3. Fonte" ...*/
            string inputString1 = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";
            var inputCollection1 = inputString1.Split(',');
            int numerator = 0;
            var numeratedString = inputCollection1.Aggregate((curent, next) => curent + $", {numerator++}. " + next);
            Console.WriteLine(numeratedString);

            /*Візьміть стрічку "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis,
              29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988" і
              перетворіть її на IEnumerable гравців в порядку віку (і ще бажано вивести вік)*/

            string inputString2 = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29 / 09 / 1976; Luke Shaw, 12 / 07 / 1995; Gaston Ramirez, 02 / 12 / 1990; Adam Lallana, 10 / 05 / 1988";
            string[] inputCollection2 = inputString2.Split(';');
            List<Player> playerCollection = new List<Player>();
            foreach (var item in inputCollection2)
            {
                string[] playerElements = item.Split(',');
                playerCollection.Add(new Player
                {
                    Name = playerElements[0],
                    DateOfBirth = DateTime.Parse(Regex.Replace(playerElements[1], @"s", ""))
                });
            }
            var resultCollection = playerCollection.OrderBy(player => player.DateOfBirth);
            foreach (var result in resultCollection)
            {
                Console.WriteLine($"{result.Name} - {result.DateOfBirth}");
            }

            //string inputString = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            /*Візьміть стрічку "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27", яка відображає довжину
              пісень в хвилинах і секундаx і обрахуйте загальну довжину всіх пісень.*/
            string inputString3 = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            string[] splitedInput = inputString3.Split(',');
            List<Time> duration = new List<Time>();
            int totalDuration = splitedInput.Select(item =>
           {
               string[] splitTime = item.Split(':');
               return new Time { Minutes = int.Parse(splitTime[0]), Seconds = int.Parse(splitTime[1]) };
           }).Sum(d => d.Minutes * 60 + d.Seconds);

            Console.WriteLine($"{totalDuration / 60}:{totalDuration % 60}");
            Console.ReadLine();
        }
    }
}
