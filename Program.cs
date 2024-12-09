using Iterator_Pattern;

public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        library.AddBook(new Book("Пророк", "Александр Пушкин", 1828));
        library.AddBook(new Book("Война и мир", "Лев Толстой", 1867));
        library.AddBook(new Book("Мёртвые души", "Николай Гоголь", 1842));

        IIterator iterator = library.CreateIterator();

        while (iterator.HasNext())
        {
            Book book = iterator.Next();
            Console.WriteLine(book);
        }
    }
}