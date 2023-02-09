using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.InterfaceExamples
{
    internal class Square : IShape, IColor
    {
        public double X { get; set; }


        public Square(double xSide)
        {
            this.X = xSide;


        }

        public string GetColor()
        {
            var randomcolor = new Random();
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Magenta" };
            return $"You have created a {colors[randomcolor.Next(0, 5)]} square";
        }

        public double CalculateArea() => Math.Pow(this.X, 2);


        public double CalculatePerimiter() => 4 * this.X;
    }
}



