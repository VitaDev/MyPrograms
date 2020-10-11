using System;

namespace Род_Стивенсон_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int LenArray = Convert.ToInt32(Console.ReadLine());
            int[] Mas = new int[LenArray];
            int j = 1;
            for (int i = 0; i < Mas.Length; i++)
            {
                if (LenArray % 2 == 0)
                {
                    if (i <= (LenArray / 2) - 1)
                    {
                        Mas[i] = i + 1;
                    }
                    else
                    {
                        Mas[i] = i - j + 1;
                        j += 2;
                    }
                }
                else
                {
                    if (i <= (LenArray / 2))
                    {
                        Mas[i] = i + 1;
                    }
                    else
                    {
                        Mas[i] = i - j;
                        j += 2;
                    }

                }
            }
            Console.Write("Массив: ");
            for (int i = 0; i < Mas.Length; i++)
            {
                Console.Write(Mas[i] + " ");
            }
        }
    }
}
