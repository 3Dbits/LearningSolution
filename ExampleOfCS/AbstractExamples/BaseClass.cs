using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.AbstractExamples
{
    internal abstract class BaseClass
    {
        protected int _x = 100;
        protected int _y = 150;

        // Abstract method
        public abstract void AbstractMethod();

        // Abstract properties
        public abstract int X { get; }
        public abstract int Y { get; }
    }
}
