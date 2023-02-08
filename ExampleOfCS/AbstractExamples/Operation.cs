using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.AbstractExamples
{
    internal abstract class Operation
    {
        public String Name { get; }

        public Operation(string name)
        {
            this.Name = name;
        }

        public abstract void Execute();
    }
}
