using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
     abstract class Shape
    {
        string name { get; set; }

    public Shape(string name) {

            this.name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name {name}");
        }
    }
}