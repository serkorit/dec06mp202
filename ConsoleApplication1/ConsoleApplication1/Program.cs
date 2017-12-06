using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle rect = new Triangle(new Point(), new Point(1,0), new Point(0,1));
            rect.Display();
            Console.WriteLine(rect.Square());

            Circle circ = new Circle(3);
            circ.Display();
            Console.WriteLine(circ.Square());

            Circle circ2 = new Circle(new Point(), new Point(4,0));
            circ2.Display();
            Console.WriteLine(circ2.Square());


            Console.ReadLine();
        }
    }
}
