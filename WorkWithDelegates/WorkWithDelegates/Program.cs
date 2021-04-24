using System;

namespace WorkWithDelegates
{
    delegate double NumberOperations(double x, double y);
    delegate void Answer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            //NumberOperations numberOperations = Sum;
            //numberOperations += Minus;
            //numberOperations += Difference;
            //numberOperations += Multiple;
            //numberOperations.Invoke(5, 8);

            NumberOperations secondNumberOperations = Minus;
            Answer answer;
            int money = 5000;
            Console.WriteLine($"Ваши деньги: {money}");
            Console.WriteLine("Сколько денег вы хотите снять со счёта?");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0 && secondNumberOperations(money, input) >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                answer = Answer;
                answer.Invoke(secondNumberOperations(money, input));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                answer = WrongAnswer;
                answer.Invoke(secondNumberOperations(money, input));
                Console.ResetColor();
            }
        }
        public static void Answer(double x)
        {
            Console.WriteLine($"На вашем счету осталось: {x}");
        }
        public static void WrongAnswer(double x)
        {
            Console.WriteLine($"Недостаточно денег на счету: {Math.Abs(x)}");
        }

        public static double Sum(double x, double y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }

        public static double Minus(double x, double y)
        {
            //Console.WriteLine(x - y);
            return x - y;
        }

        public static double Difference(double x, double y)
        {
            Console.WriteLine(x / y);
            return x / y;
        }

        public static double Multiple(double x, double y)
        {
            Console.WriteLine(x * y);
            return x * y;
        }
    }
}
