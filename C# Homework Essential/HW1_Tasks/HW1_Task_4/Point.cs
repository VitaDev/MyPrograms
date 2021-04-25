namespace HW1_Task_4
{
    public class Point
    {
        public Point(string name, int x, int y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public string Name { get; }

        public int X { get; }

        public int Y { get; }
    }
}
