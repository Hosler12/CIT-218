using Microsoft.EntityFrameworkCore;

namespace OnMyOwn.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Banana: The Fate of the Fruit That Changed the World",
                    Year = 2008,
                    Cost = 14.89,
                    Genre = "Non-Fiction"
                },
                new Book
                {
                    BookId = 2,
                    Title = "Bananeras: Women Transforming the Banana Unions of Latin America",
                    Year = 2005,
                    Cost = 18.00,
                    Genre = "Non-Fiction"
                },
                new Book
                {
                    BookId = 3,
                    Title = "Banana Cultures: Agriculture, Consumption, and Environmental Change in Honuras and the United States",
                    Year = 2006,
                    Cost = 11.99,
                    Genre = "Non-Fiction"
                }
            );
        }
    }
}
