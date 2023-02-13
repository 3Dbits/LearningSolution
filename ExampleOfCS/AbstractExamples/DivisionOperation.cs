using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.AbstractExamples
{
    internal class DivisionOperation : Operation
    {
        public DivisionOperation() : base("DivisionOperation")
        {
        }

        public override void Execute()
        {
            Console.WriteLine("First number: ");
            double first = Double.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            double second = Double.Parse(Console.ReadLine());

            Console.WriteLine($"The reminder of the numbers is { first / second }");
        }
    }
}
