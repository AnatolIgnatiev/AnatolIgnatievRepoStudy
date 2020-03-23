using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry
/*статичиний клас StudentRegistry, який матиме методи AddStudent( Student) i RemoveStudent(Student), I GetAllInfo(), 
* який поверне стрічку з інформацією про всіх студентів, в якій кожен наступний студент починатиметься з наступного рядочка. */
{
    public static class StudentRegistry
    {
        public static List<Student> students = new List<Student>();
        public static Student AddStudent(Student student)
        {
            DateTime inputDate = new DateTime();
            Console.WriteLine("Enter Date and time of students admission (dd.mm.yyyy h:mm:ss) or enter empty string if student is admiting now: ");
            string date = Console.ReadLine();
            if (!string.IsNullOrEmpty(date) || DateTime.TryParse(date,out inputDate))
            {
                student.DateOfAdmission = inputDate;
            }
            else
            {
                student.DateOfAdmission = DateTime.Now;
            }

            Console.WriteLine("Enter new students name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter new students surname: ");
            student.LastName = Console.ReadLine();

            Console.WriteLine("Enter students adress in next format: country,city,street,house,appartment");
            string[] inputAdress = Console.ReadLine().Split(',');
            student.Address.country = inputAdress[0];
            student.Address.city = inputAdress[1];
            student.Address.address = inputAdress[2] + "," + inputAdress[3] + "," + inputAdress[4];
            Console.WriteLine();

            students.Add(student);
            return student;
        }
        
        public static bool RemoveStudent(Student student) // search by object
        {
            bool result = false;
            if (students.Remove(student))
            {
                result = true;
            }
            return result;
        }
        public static string GetAllInfo()
        {
            string result = null;
            foreach (var student in students)
            {
                result = result + $"I am student {student.Name} {student.LastName}, I have started studying in {student.DateOfAdmission}.\n";
            }
            return result;
        }
    }
}
