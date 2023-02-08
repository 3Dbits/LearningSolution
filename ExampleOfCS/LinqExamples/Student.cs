using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.LinqExamples
{
    public class Student
    {
        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public int Age { get; set;}

        public override string? ToString()
        {
            return $"StudentID: { StudentID }, Name: { StudentName}, Age: { Age}";
        }
    }
}
