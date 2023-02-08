using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.InheritanceExamples
{
    public class ColorPoint : Point
    {
        private readonly string color;

        public ColorPoint(int x, int y, string color) : base(x, y)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return $"{ base.ToString() } color: { color }";
        }
    }
}
