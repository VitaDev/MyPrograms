using System;

namespace _5._56
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Mas = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Mas[i] = rand.Next(50);
                Result += Math.Abs(Mas[i]);
            }
            Console.WriteLine("Результат: "+Result);
        }
    }
}
