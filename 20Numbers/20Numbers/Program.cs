using System;
using System.Collections;
using System.Collections.Generic;

namespace _20Numbers
{
    class Program
    {
        public static void printList(List<int> list)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();

            foreach (int item in list)
            {
                if (item % 3 == 0)
                    list1.Add(item);
                if (item % 2 == 0)
                    list2.Add(item);
                if (item % 3 != 0 && item % 2 != 0)
                    list3.Add(item);
            }
            Console.WriteLine("Первый список %3:");
            foreach (int item in list1)
                Console.WriteLine(item);
            Console.WriteLine("------------------");
            Console.WriteLine("Второй список %2:");
            foreach (int item in list2)
                Console.WriteLine(item);
            Console.WriteLine("------------------");
            Console.WriteLine("Третий список:");
            foreach (int item in list3)
                Console.WriteLine(item);
            Console.WriteLine("------------------");
        }
        static void Main(string[] args)
        {
            List<int> mainList = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                mainList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            printList(mainList);
        }
    }
}
