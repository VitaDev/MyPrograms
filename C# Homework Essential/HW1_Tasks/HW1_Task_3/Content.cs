using System;

namespace HW1_Task_3
{
    public class Content
    {
        public string ContentOfBook { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Название книги: {this.ContentOfBook}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
