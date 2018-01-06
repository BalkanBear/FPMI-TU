using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public string FirstName { get; set;  }
        public string LastName { get; set;  }
        public int Age { get; set;  }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student() {FirstName="Pesho", LastName="Ivanov", Age=20},
                new Student() {FirstName="Ivan", LastName = "Petrov", Age=18},
                new Student() {FirstName="Kiro", LastName="Nikolov", Age=21}
            };
            foreach (var s in students)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.Age);
            }

            Array.Sort(students, (s1, s2) => s1.Age.CompareTo(s2.Age));
            Console.WriteLine();
            Console.WriteLine();
            foreach (var s in students)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.Age);
            }

            Array.Sort(students, (s1, s2) => s1.LastName.CompareTo(s2.LastName));
            Console.WriteLine();
            Console.WriteLine();
            foreach (var s in students)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.Age);
            }
        }
    }
}
