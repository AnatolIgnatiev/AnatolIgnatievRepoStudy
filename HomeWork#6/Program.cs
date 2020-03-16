using System;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Learn C# by stepping through the basics with Bob: get the tools, see how to write code, debug features, explore customizations, and much more ! Search for and focus on the information you need, in this C# for beginners course, which has topics separated out into individual videos. Get to know the grammar, create and use methods, manipulate strings, and see how to handle events. Plus, get a look at next steps as you learn to develop Windows and web applications.";
            Console.WriteLine(text.Substring(text.IndexOf('!')+2).Replace("cs","c's"));
            int counterOfEts = 0;
            while (text.Contains("et"))
            {
                counterOfEts++;
                text = text.Remove(text.IndexOf("et"),2);
            }
            Console.WriteLine(counterOfEts);
            Console.ReadLine();
        }
    }
}
