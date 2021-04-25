using System;

namespace HW1_Task_3
{
    public class Title
    {
        public string TitleOfBook { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Название книги: {this.TitleOfBook}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
