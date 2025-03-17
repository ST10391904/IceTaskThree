using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    class Circle: Shape, Interface
    {
        double radius { get; set; }

        public Circle(double radius, string name) : base(name)
        {
            this.radius = radius;
        }

        public double calculateArea()
        {
            double RadArea = Math.Pow(radius,2);
            double CircleArea = Math.PI * RadArea;
            return CircleArea;

        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius {radius}, x π \nArea: {calculateArea()}");
        }
    }
}
