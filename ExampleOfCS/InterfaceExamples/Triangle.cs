using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.InterfaceExamples
{
    //Jednakostraničan trokut only
    internal class Triangle : IShape,IColor
    {

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Triangle(double xSide, double ySide, double zSide)
        {
            this.X = xSide;

            this.Y = ySide;

            this.Z = zSide;
        }

        public string GetColor()
        {
            var randomcolor = new Random();
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Magenta" };
            return $"You have created a {colors[randomcolor.Next(0,5)] } triangle";
        }

        public double CalculateArea()
        {
            var semiperimiter = CalculatePerimiter() / 2;
            double Area = Math.Sqrt(semiperimiter * (semiperimiter - this.X) * (semiperimiter - this.Y) * (semiperimiter - this.Z));
            return Area;
        }

        public double CalculatePerimiter()
        {
            return this.X + this.Y + this.Z;
        }




  
    }
}
