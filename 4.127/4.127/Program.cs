using System;

namespace _4._127
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость товара в копейках: ");
            int CoinValue = Convert.ToInt32(Console.ReadLine());
            if (CoinValue < 100)
            {
                Console.WriteLine("Стоимость товара: " + CoinValue + " копеек.");
            }
            else if (CoinValue % 100 == 0)
            {
                Console.WriteLine("Стоимость товара: " + CoinValue / 100 + " рублей.");
            }
            else
                Console.WriteLine("Стоимость товара: " + CoinValue / 100 + " рублей " + CoinValue % 100 + " копеек.");

        }
    }
}
