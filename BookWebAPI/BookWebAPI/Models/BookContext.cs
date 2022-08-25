using Microsoft.EntityFrameworkCore;

namespace BookWebAPI.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            //Used to create a Database
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
    }
}
