namespace LibraryApp.Domain
{
    public class Book
    {

        public string Isbn { get; set; }

        public string Title { get; set; }

        public BookSizes Size { get; set; }

        public Author Auther { get; set; }

        public int PublisYear { get; set; }
    }

}
