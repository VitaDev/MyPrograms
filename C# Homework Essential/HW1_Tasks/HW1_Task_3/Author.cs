using System;

namespace HW1_Task_3
{
    public class Author
    {
        public string AuthorOfBook { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Автор книги: {this.AuthorOfBook}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
