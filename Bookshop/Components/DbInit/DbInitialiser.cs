using Bookshop.Components.Contexts;
using Bookshop.Components.Schemas;

namespace Bookshop.Components.DbInit
{
    /// <summary>
    /// Populates the given BookshopContext with the initial set of data, and saves the changes
    /// </summary>
    internal class DbInitialiser
    {
        internal static void Initialise(BookshopContext dbContext)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            dbContext.Database.EnsureCreated();
            if (dbContext.Books.Any()) return;

            Book[] books = new Book[]
            {
                new Book(1, "Winnie The Pooh", "A.A Milne", 19.25),
                new Book(2, "Pride and Prejudice", "Jane Austen", 5.49),
                new Book(3, "Romeo and Juliet", "William Shakespeare", 6.95),
            };

            foreach (Book book in books)
                dbContext.Books.Add(book);

            dbContext.SaveChanges();
        }
    }
}
