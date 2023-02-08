using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.LinqExamples
{
    delegate bool FindStudent(Student std);

    class StudentExtension
    {
        public static List<Student> where(Student[] stdArray, FindStudent del)
        {
            List<Student> result = new();
            foreach (Student std in stdArray)
                if (del(std))
                {
                    result.Add(std);
                }

            return result;
        }
    }

    class ProgramForStudents
    {
        public void StartProgram()
        {
            Student[] studentArray =
            {
                new Student() { StudentID = 1, StudentName = "John",   Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",   Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" ,   Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" ,   Age = 31 } ,
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                new Student() { StudentID = 7, StudentName = "Rob",    Age = 19 } ,
            };

            List<Student> students = StudentExtension.where(studentArray, delegate (Student std)
            {
                return std.Age > 12 && std.Age < 20;
            });

            foreach (Student student in students) 
            {
                Console.WriteLine(student);
            }
        }
    }
}
