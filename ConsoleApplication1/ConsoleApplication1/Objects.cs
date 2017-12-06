using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Triangle : GeomObject
    {
        public List<Line> Lines = new List<Line>();
        public Triangle(Point p1, Point p2, Point p3)
        {
            AddPoint(p1);
            AddPoint(p2);
            AddPoint(p3);
            Lines = new List<Line>();
            Lines.Add(new Line(p1, p2));
            Lines.Add(new Line(p2, p3));
            Lines.Add(new Line(p3, p1));
        }

        public override void Display()
        {
            for(int i = 0; i < TotalPoints; i++)
            {
                Console.WriteLine("({0},{1})",points[i].X, points[i].Y);
            }
        }

        public override double Square()
        {
            double P = 0;
            foreach (Line line in Lines) P += line.Size;
            P /= 2;

            return Math.Sqrt(P * (P - Lines[0].Size) * (P - Lines[1].Size) * (P - Lines[2].Size));
        }
    }
    public class Circle : GeomObject
    {
        public double R;
        public double D { get { return R*2;} }

        public Circle(int r)
        {
            R = r;
            points.Add(new Point());
        }
        public Circle(Point p1, Point p2)
        {
            R = new Line(p1, p2).Size;
        }

        public override void Display()
        {
            Console.WriteLine("R = {0}, D = {1}", R, D);
        }
        public override double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
