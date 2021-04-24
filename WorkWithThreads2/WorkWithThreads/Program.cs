using System;
using System.Threading;

namespace WorkWithThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Многопоточное вычисление факториала, двойного факториала и числа фибоначи");
            Console.Write("Для начала вычисления, введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Основной поток начал выполнять свою работу:  { Thread.CurrentThread.ManagedThreadId }");

            Thread thread_1 = new Thread(new ParameterizedThreadStart(Calculation.Factorial));
            thread_1.Start(n);

            Thread thread_2 = new Thread(new ParameterizedThreadStart(Calculation.DoubleFactorial));
            thread_2.Start(n);

            Thread thread_3 = new Thread(new ParameterizedThreadStart(Calculation.Fibonachi));
            thread_3.Start(n);

            if (thread_1.IsAlive)
            {
                thread_1.Join();
            }

            if (thread_2.IsAlive)
            {
                thread_2.Join();
            }

            if (thread_3.IsAlive)
            {
                thread_3.Join();
            }
            Console.WriteLine("Основной поток закончил выполнять свою работу");
        }
    }

    class Calculation
    {
        public static void Factorial(object num)
        {
            Console.WriteLine($"Вторичный поток начал выполнять свою работу:  { Thread.CurrentThread.ManagedThreadId }");

            int n = (int)num;

            double factorial = 1;
            for (int i = n; i > 1; i--)
            {
                factorial *= i;
                Thread.Sleep(100);
            }          

            Console.WriteLine($"Вторичный поток закончил выполнять свою работу: { Thread.CurrentThread.ManagedThreadId }");

            Console.WriteLine($"Факториал: {factorial}");
        }

        public static void DoubleFactorial(object num)
        {
            Console.WriteLine($"Вторичный поток начал выполнять свою работу:  { Thread.CurrentThread.ManagedThreadId }");

            int n = (int)num;

            double factorial = 1;
            for (int i = n; i > 1 || i > 2; i -= 2)
            {
                factorial *= i;
                Thread.Sleep(100);
            }

            Console.WriteLine($"Вторичный поток закончил выполнять свою работу: { Thread.CurrentThread.ManagedThreadId }");

            Console.WriteLine($"Двойной факториал: {factorial}");
        }

        public static void Fibonachi(object num)
        {
            Console.WriteLine($"Вторичный поток начал выполнять свою работу:  { Thread.CurrentThread.ManagedThreadId }");

            int n = (int)num;

            int j = 1;
            for (int i = 1; i <= n; i += j)
            {
                Console.Write($"{i} ");
                j = i - j;
                Thread.Sleep(500);
            }

            Console.WriteLine($"Вторичный поток закончил выполнять свою работу: { Thread.CurrentThread.ManagedThreadId }");
        }
    }
}
