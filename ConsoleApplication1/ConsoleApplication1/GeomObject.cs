using System;
using System.Collections.Generic;


namespace ConsoleApplication1
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int _x , int _y)
        {
            X = _x;
            Y = _y;
        }
    }
    public class Line
    {
        public double Size
        {
            get { return Math.Sqrt(Math.Pow(P2.X - P1.X,2) + Math.Pow(P2.Y - P1.Y,2));}
        }
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public Line(int x1, int y1, int x2, int y2)
        {
            P1 = new Point(x1, y1);
            P2 = new Point(x2, y2);
        }

        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }
    }
    public abstract class GeomObject
    {
        public List<Point> points { get; set; }
        public int TotalPoints
        {
            get { return points.Count; }
        }

        public GeomObject()
        {
            points = new List<Point>();
        }

        public virtual void Display()
        {
            Console.WriteLine("({0},{1})", points[0].X, points[0].Y);
        }
        public virtual double Square()
        {
            return 1;
        }

        public void AddPoint(int x, int y)
        {
            points.Add(new Point(x, y));
        }

        public void AddPoint(Point p)
        {
            points.Add(p);
        }
    }
}
