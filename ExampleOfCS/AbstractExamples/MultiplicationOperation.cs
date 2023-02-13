using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.AbstractExamples
{
    internal class MultiplicationOperation : Operation
    {
        public MultiplicationOperation() : base ("MultiplicationOperation")
        {

        }

        public override void Execute()
        {
            Console.WriteLine("First number: ");
            int first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int second = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"The product of the numbers is {first * second}");
        }
    }
}
