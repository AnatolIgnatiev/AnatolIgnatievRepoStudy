using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry
/*статичиний клас StudentRegistry, який матиме методи AddStudent( Student) i RemoveStudent(Student), I GetAllInfo(), 
* який поверне стрічку з інформацією про всіх студентів, в якій кожен наступний студент починатиметься з наступного рядочка. */
{
    public class StudentRegistry
    {
        public static List<Student> students = new List<Student>();
        public static Student AddStudent(Student student)
        {
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
