using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry
/*Створити консольну програму, яка дозволить вести облік студентів. Для цього потрібно: пошукати інформацію про такий тип як “List”. 
 * Отже слід зробити статичиний клас StudentRegistry, який матиме методи AddStudent( Student) i RemoveStudent(Student), I GetAllInfo(), 
 * який поверне стрічку з інформацією про всіх студентів, в якій кожен наступний студент починатиметься з наступного рядочка. 
 * Клас Student повинен містити Ім”я, прізвище, дату поступлення у ВУЗ, а також поле типу StudentAddress. 
 * Клас Student повинен мати метод, GetStudentInfo, який поверне стрічку в зрозумілому форматі, де міститиме всю можливу інформацію про студента. 
 * Клас StudentAddress повинен містити такі дані: країна, місто, адреса.*/

{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                StudentRegistry.AddStudent(student);
                Console.WriteLine(student.GetStudentInfo());
            }

            Console.WriteLine(StudentRegistry.GetAllInfo());

            StudentRegistry.RemoveStudent(StudentRegistry.students[0]);

            Console.ReadLine();
        }
    }
}
