using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.AbstractExamples
{
    internal class MinusOperation : Operation
    {

        public MinusOperation() : base("MinusOperation")
        {

        }

        public override void Execute()
        {
            Console.WriteLine("First number: ");
            int first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int second = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"The subtraction of the numbers is {first - second}"); ;
        }
    }
}
