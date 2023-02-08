using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.InheritanceExamples
{
    public class Point3D : Point
    {
        private readonly int z;

        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        private new string Location()
        {
            return $"{ base.Location() }, { z }";
        }

        public new int ManhattanDistanceFromOrigin()
        { 
            return base.ManhattanDistanceFromOrigin() + Math.Abs(z);
        }

        public override string ToString()
        {
            return $"({ this.Location() }) distance { this.ManhattanDistanceFromOrigin() }";
        }
    }
}
