using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.InheritanceExamples
{
    public class Point
    {
        private readonly int x;
        private readonly int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int ManhattanDistanceFromOrigin()
        {
            return Math.Abs(x) + Math.Abs(y);
        }

        protected String Location()
        {
            return $"{x}, {y}";
        }

        public override string ToString()
        {
            return $"({this.Location()}) distance {this.ManhattanDistanceFromOrigin()}";
        }
    }
}
