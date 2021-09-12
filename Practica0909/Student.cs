using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0909
{
    class Student
    {
        public int idStudent { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }
        public int age { get; set; }
        public string nacionalidades { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{idStudent= 1001, firstName = "Eliezer", lastName = "Diaz", age = 18, nacionalidades="Canadiense" },
                new Student{idStudent= 1002, firstName = "Javier", lastName = "Benavidez", age = 19, nacionalidades="Mexicano" },
                new Student{idStudent= 1003, firstName = "Mauricio", lastName = "Avalos", age = 23, nacionalidades="Estadounidense" },
                new Student{idStudent= 1004, firstName = "José", lastName = "Caballeros", age = 22, nacionalidades="Africano" },
                new Student{idStudent= 1005, firstName = "Armando", lastName = "Fuentes", age = 21, nacionalidades="salvadoreño" },
            };
            return students;
        }
    }
}

