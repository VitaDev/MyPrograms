namespace HW1_Task_2
{
    public class Rectangle
    {
        public Rectangle(double side1, double side2)
        {
            this.FirstSide = side1;
            this.SecondSide = side2;
        }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public double Area 
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

        private double AreaCalculator()
        {
            return this.FirstSide * this.SecondSide;
        }

        private double PerimeterCalculator()
        {
            return (this.FirstSide + this.SecondSide) * 2;
        }
    }
}
