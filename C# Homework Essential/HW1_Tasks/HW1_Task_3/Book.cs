namespace HW1_Task_3
{
    public class Book
    {
        public Book(string title, string author, string content)
        {
            this.Title = new Title { TitleOfBook = title };
            this.Author = new Author { AuthorOfBook = author };
            this.Content = new Content { ContentOfBook = content };
        }

        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }

        public void Show()
        {
            this.Title.Show();
            this.Author.Show();
            this.Content.Show();
        }
    }
}
