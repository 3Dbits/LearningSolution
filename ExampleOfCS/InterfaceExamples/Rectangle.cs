using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.InterfaceExamples
{
    internal class Rectangle : IShape, IColor
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Rectangle(double xSide, double ySide)
        {
            this.X = xSide;

            this.Y = ySide;


        }

        public string GetColor()
        {
            var randomcolor = new Random();
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Magenta" };
            return $"You have created a {colors[randomcolor.Next(0, 5)]} rectangle";
        }

        public double CalculateArea() => this.X * this.Y;
        
        public double CalculatePerimiter() => 2 * (this.X + this.Y);
        
    }

}