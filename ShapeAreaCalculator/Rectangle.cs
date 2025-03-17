using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    internal class Rectangle : Shape, Interface
    {

        public double width {get; set;}
        public double length { get; set; }

        public Rectangle(double width, double length, string name) : base(name)
        {
            this.width = width;
            this.length = length;
        }

        public double calculateArea()
        {
            double RectangleCalc = length * width;
            return RectangleCalc;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Width: {width}, \nLength: {length}, \nArea: {calculateArea()}");
        }

    }
}