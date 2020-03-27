using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork8
{
    class HomeWork8
    /*Створити програму, яка виконуватиме операції створення, копіювання і видалення файлів.
      Програма питатиме в користувавча “Please input file operation create/delete/copy <file path>”. Для прикладу користувач вводить: create c:\temp\test.txt. 
      -Програма відповідно створює в папці c:\temp новий файл test.txt, 
      -якщо такий файл вже існує, то повинна вивести повідомлення і отримати відповідь від користувача: “Do you want to overwrite ? y/n” 
      -Відповідно y - перетерти файл. Така ж сама ситуація з операцією копіювання. 
      -Обробити такі випадки і виводити зрозумілі для
      користувача повідомлення:
      -Файл відкритий іншою програмою і не може бути змінений чи видалений
      -Неправильний шлях до файлу, чи неіснуюча папка вказана
      -Шлях до файлу довший за 256 символів*/
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please input file operation create/delete/copy and file path");
            string[] inputArray = Console.ReadLine().Split(' ');
            string operationType = inputArray[0];
            string filePath = inputArray[1];
            FileOperations operation = new FileOperations();
            switch (operationType)
            {
                case "create":
                    operation.CreateFile(filePath);
                    break;
                case "Create":
                    goto case "create";

                case "delete":
                    operation.DeleteFile(filePath);
                    break;
                case "Delete":
                    goto case "delete";

                case "copy":
                    Console.WriteLine("Please enter path to copy file");
                    string copyFilePath = Console.ReadLine();
                    operation.CopyFile(filePath, copyFilePath);
                    break;
                case "Copy":
                    goto case "copy";

                default: 
                    Console.WriteLine("Invalid operation type input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
