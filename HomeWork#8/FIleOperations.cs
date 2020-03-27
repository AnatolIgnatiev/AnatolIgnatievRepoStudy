using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork8
{
    class FileOperations
	{
		public void CreateFile(string filePath)
		{
			try
			{
				if (File.Exists(filePath))
				{
					Console.WriteLine("Do you want to overwrite ? y/n");
					char usersAnswer;
					if (char.TryParse(Console.ReadLine(), out usersAnswer) && usersAnswer == 'y')
					{
						File.Create(filePath).Close();
						Console.WriteLine("File created again");
					}
					else if (char.TryParse(Console.ReadLine(), out usersAnswer) && usersAnswer == 'n')
					{
						return;
					}
					else
					{
						Console.WriteLine("Can`t understand your answer...");
					}
				}
				else
				{
					File.Create(filePath).Close();
					Console.WriteLine("File created");
				}
			}
			catch (PathTooLongException exeption)
			{
				Console.WriteLine("File path is longer then 256 symbols");
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
			catch (DirectoryNotFoundException exeption)
			{
				Console.WriteLine("The file path is incorrect or the folder is missing");
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
			catch (IOException exeption)
			{
				Console.WriteLine("The file is in use");
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
			catch (Exception exeption)
			{
				Console.WriteLine(exeption);
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
		}
		public void DeleteFile(string filePath)
		{
			try
			{
				File.Delete(filePath);
			}
			catch (PathTooLongException exeption)
			{
				Console.WriteLine("File path is longer then 256 symbols");
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
			catch (DirectoryNotFoundException exeption)
			{
				Console.WriteLine("The file path is incorrect or the folder is missing");
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
			catch (IOException exeption)
			{
				Console.WriteLine("The file is in use");
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
			catch (Exception exeption)
			{
				Console.WriteLine(exeption);
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
		}
		public void CopyFile(string filePath, string destFilePath)
		{
			try
			{
				if (File.Exists(destFilePath))
				{
					Console.WriteLine("Do you want to overwrite ? y/n");
					char usersAnswer;
					if (char.TryParse(Console.ReadLine(), out usersAnswer) && usersAnswer == 'y')
					{
						File.Create(destFilePath).Close();
					}
					else if (char.TryParse(Console.ReadLine(), out usersAnswer) && usersAnswer == 'n')
					{
						return;
					}
					else
					{
						Console.WriteLine("Can`t understand your answer...");
					}
				}
				else
				{
					File.Copy(filePath, destFilePath);
				}
			}
			catch (PathTooLongException exeption)
			{
				Console.WriteLine("File path is longer then 256 symbols");
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
			catch (DirectoryNotFoundException exeption)
			{
				Console.WriteLine("The file path is incorrect or the folder is missing");
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
			catch (IOException exeption)
			{
				Console.WriteLine("The file is in use");
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
			catch (Exception exeption)
			{
				Console.WriteLine(exeption);
				Loger loger = new Loger();
				loger.Log(exeption, Directory.GetParent(filePath) + "Log.txt");
			}
		}
	}
}
