using System;

namespace WorkWithDelegates_2
{
    delegate double MyDelegate(double number);
    delegate double MySecondDelegate(double number, MyDelegate @delegate);
    class Program
    {
        static void Main(string[] args)
        {
            MySecondDelegate mySecondDelegate = EvenNumber;

            MyDelegate myDelegate = PowNumber;

            Console.WriteLine("Чётные числа\nx | F(x)");
            for (double i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} | {mySecondDelegate.Invoke(i, myDelegate)}");
                }
            }

            mySecondDelegate -= EvenNumber;
            mySecondDelegate += OddNumber;

            Console.WriteLine("\nНечётные числа\nx | F(x)");
            for (double i = 0; i < 6; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i} | {mySecondDelegate.Invoke(i, myDelegate)}");
                }
            }
        }

        public static double EvenNumber(double number, MyDelegate @delegate)
        {
            return @delegate(number);
        }

        public static double OddNumber(double number, MyDelegate @delegate)
        {
            return @delegate(number);
        }

        public static double PowNumber(double number)
        {
            return Math.Pow(number, 2);
        }
    }
}
