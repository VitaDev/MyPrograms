using System;

namespace WorkWithDelegates_4
{
    delegate double MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, double> func = (x, y) => 
            {
                double result = Math.Pow(x, 2) + Math.Pow(y, 2);
                Console.WriteLine(result);
                return result;
            };

            MyDelegate myDelegate = UsingDelegate(func);

            Console.WriteLine(myDelegate());
        }

        public static double MathPowSum(int x, int y)
        {
            double result = Math.Pow(x, 2) + Math.Pow(y, 2);
            Console.WriteLine(result);
            return result;
        }

        public static MyDelegate UsingDelegate(Func<int, int, double> func)
        {
            return () =>
            {
                double z = func(10, 20);
                return Math.Pow(z, 2);
            };    
        }
    }
}
