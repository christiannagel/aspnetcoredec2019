using Microsoft.EntityFrameworkCore;

namespace WebAppWithEFCore.Models
{
    public class BooksContext : DbContext
    {
        // without DI
        //public BooksContext()
        //{

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(connectionstring);
        //}

        // with DI
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().Property(b => b.Publisher).HasMaxLength(20);
        }
    }
}
