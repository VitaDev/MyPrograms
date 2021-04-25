namespace HW1_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point("Точка 1", 0, 0);
            Point point2 = new Point("Точка 2", 4, 10);
            Point point3 = new Point("Точка 3", 8, -2);

            Figure figure = new Figure(point1, point2, point3);
            figure.PerimeterCalculator();
        }
    }
}
