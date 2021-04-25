using System;

namespace HW1_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон прямоугольника");

            Console.Write("Первая сторона: ");
            double firstSide = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вторая сторона: ");
            double secondSide = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(firstSide, secondSide);

            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
        }
    }
}
