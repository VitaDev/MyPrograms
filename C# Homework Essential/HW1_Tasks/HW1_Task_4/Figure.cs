using System;
using System.Collections.Generic;
using System.Text;

namespace HW1_Task_4
{
    public class Figure
    {
        public Figure(Point a, Point b, Point c)
        {
            this.Points = new List<Point>();
            Points.Add(a);
            Points.Add(b);
            Points.Add(c);
            Console.WriteLine("Треугольник");
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            this.Points = new List<Point>();
            Points.Add(a);
            Points.Add(b);
            Points.Add(c);
            Points.Add(d);
            Console.WriteLine("Четырехугольник");
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            this.Points = new List<Point>();
            Points.Add(a);
            Points.Add(b);
            Points.Add(c);
            Points.Add(d);
            Points.Add(e);
            Console.WriteLine("Пятиугольник");
        }

        public List<Point> Points { get; set; }

        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double sum = 0;
            Point[] points = this.Points.ToArray();
            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += LengthSide(points[i], points[i + 1]);
            }

            Console.WriteLine($"Периметр фигуры равен: {sum}");
        }
    }
}
