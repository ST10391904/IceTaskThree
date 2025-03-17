namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle RA = new Rectangle(10, 20, "Rectangle");
            RA.Display();
            RA.calculateArea();


            Console.WriteLine();
            Circle CA = new Circle(10, "Circle");
            CA.Display();
            CA.calculateArea();
        }
    }
}