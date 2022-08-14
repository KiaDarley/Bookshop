using Bookshop.Components.Schemas;
using Microsoft.EntityFrameworkCore;

namespace Bookshop.Components.Contexts
{
    /// <summary>
    /// A BookshopContext is an instance of DbContext, containing the DbSet of Book instances, available for query
    /// </summary>
    public class BookshopContext : DbContext
    {
        public BookshopContext(DbContextOptions<BookshopContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}
