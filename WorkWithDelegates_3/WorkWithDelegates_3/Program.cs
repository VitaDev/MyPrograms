using System;

namespace WorkWithDelegates_3
{
    public delegate void Betta(string s);

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass(10);
            MyClass myClass2 = new MyClass(25);

            Random random = new Random();
            myClass1.alphaEvent += delegate (int x) 
            {
                int result = x + random.Next(0, 100);
                Console.WriteLine(result);
                return result;
            };
            myClass2.alphaEvent += delegate (int x)
            {
                int result = x + random.Next(0, 100);
                Console.WriteLine(result);
                return result;
            };

            myClass1.Number = 228;

            Betta betta = SortString;
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            betta.Invoke(input);
        }

        public static void SortString(string s)
        {
            string result = null;

            foreach (var item in s)
            {
                if (s[s.Length - 1] != item)
                {
                    result += $"{item} | ";
                }
                else
                {
                    result += $"{item}";
                }
            }
            Console.WriteLine(result);
        }
    }
}
