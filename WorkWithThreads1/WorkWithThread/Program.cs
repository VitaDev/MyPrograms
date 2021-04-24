using System;
using System.Threading;

namespace WorkWithThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Главный поток: {Thread.CurrentThread.ManagedThreadId}");

            int size = 20;

            char[] mas = new char[size];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = '*';
                Console.Write($"| {mas[i]}");
            }
            Console.WriteLine("|");

            int firstIndex = 0;
            int lastIndex = mas.Length-1;

            Thread A, B;

            A = new Thread(() => 
            {
                Console.WriteLine($"Вторичный поток: {Thread.CurrentThread.ManagedThreadId}");

                char firstValue = 'Я';

                while (true)
                {
                    if (lastIndex > firstIndex)
                    {
                        mas[lastIndex] = firstValue;
                        firstValue--;
                        lastIndex--;

                        Thread.Sleep(100);
                    }
                    else
                    {
                        Thread.CurrentThread.Interrupt();
                        break;
                    }
                }
                Console.WriteLine($"Вторичный поток {Thread.CurrentThread.ManagedThreadId} завершил свою работу");
            });

            B = new Thread(() =>
            {
                Console.WriteLine($"Вторичный поток: {Thread.CurrentThread.ManagedThreadId}");

                char firstValue = 'А';

                while (true)
                {
                    if (firstIndex < lastIndex)
                    {
                        mas[firstIndex] = firstValue;
                        firstValue++;
                        firstIndex++;

                        Thread.Sleep(100);
                    }
                    else
                    {
                        Thread.CurrentThread.Interrupt();
                        break;
                    }
                }
                Console.WriteLine($"Вторичный поток {Thread.CurrentThread.ManagedThreadId} завершил свою работу");
            });

            A.Start();
            B.Start();

            if (A.IsAlive) A.Join();
            if (B.IsAlive) B.Join();

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"| {mas[i]}");
            }
            Console.WriteLine("|");

            Console.WriteLine($"Главный поток {Thread.CurrentThread.ManagedThreadId} завершил свою работу");
        }
    }
}
