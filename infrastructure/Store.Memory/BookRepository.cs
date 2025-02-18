namespace Store.Memory
{
    public class BookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art of programming"),
            new Book(2, "Refactoring"),
            new Book(3, "Programming Language"),
        };

       public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(books => books.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
