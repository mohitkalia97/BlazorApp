using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

namespace BlazorApp.DB
{
    public class BookDbContext : DbContext
    {
        public DbSet<Models.Book> Books { get; set; }

        public static BookDbContext Create(IMongoDatabase database) =>
          new(new DbContextOptionsBuilder<BookDbContext>()
              .UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName)
              .Options);

        public BookDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Book>(o =>
            {
                o.ToCollection("Book");
            });
        }
    }
}
