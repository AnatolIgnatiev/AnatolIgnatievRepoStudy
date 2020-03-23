using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry
/*Клас Student повинен містити Ім”я, прізвище, дату поступлення у ВУЗ, а також поле типу StudentAddress. 
* Клас Student повинен мати метод, GetStudentInfo, який поверне стрічку в зрозумілому форматі, де міститиме всю можливу інформацію про студента. */
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        private DateTime dateOfAdmission;
        public DateTime DateOfAdmission
        {
            get
            {
                return this.dateOfAdmission;
            }
            set
            {
                if (value <= DateTime.Now)
                {
                    dateOfAdmission = value;
                }
            } 
        }
        public StudentAddress Address = new StudentAddress();
        public string GetStudentInfo()
        {
            return $"Name : {Name}, Last Name : {LastName}, Date of admission : {DateOfAdmission}, {Address.ToString()} \n";
        }
    }
}
