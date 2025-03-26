namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookLibrary = new Library<Book>();

            bookLibrary.Add(new Book(52, "Драма", "Копатыч", "ТОже копатыч", 2077, true));
            bookLibrary.Add(new Book(44, "Боевик", "Хз", "копатыч", 2077, false));

            bookLibrary.PrintAll();

            List<Book> list = new List<Book>();

            list = bookLibrary.FindBooks(2000);
            
        }
    }
}
