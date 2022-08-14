using Microsoft.EntityFrameworkCore;

namespace Bookshop.Models
{
    public class BookshopContext : DbContext
    {
        public BookshopContext(DbContextOptions<BookshopContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}
