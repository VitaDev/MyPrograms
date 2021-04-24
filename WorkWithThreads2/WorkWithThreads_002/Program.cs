using System;
using System.Threading;

namespace WorkWithThreads_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main thread - { Thread.CurrentThread.ManagedThreadId } start work. ");

            Thread workThread = new Thread(new ParameterizedThreadStart(new Action<object>(MyWork.DoWork)));

            workThread.Start("*");


            for (int i = 0; i < 20; i++)
            {
                Console.Write(".");
                Thread.Sleep(30);
            }

            if (workThread.IsAlive)
            {
                workThread.Join();
            }

            Console.WriteLine($"Main thread - { Thread.CurrentThread.ManagedThreadId } end work. ");
            Console.Read();
        }
    }

    class MyWork
    {
        public static void DoWork(object ch)
        {
            Console.WriteLine($"Second thread - { Thread.CurrentThread.ManagedThreadId } start work. ");

            for (int i = 0; i < 100; i++)
            {
                Console.Write(ch);
                Thread.Sleep(55);
            }

            Console.WriteLine($"\nSecond thread - { Thread.CurrentThread.ManagedThreadId } end work. ");
            Console.WriteLine(Thread.CurrentThread.IsBackground); 
        }
    }
}
