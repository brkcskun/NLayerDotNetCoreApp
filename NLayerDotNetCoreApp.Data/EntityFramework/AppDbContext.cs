using Microsoft.EntityFrameworkCore;
using NLayerDotNetCoreApp.Core.Models;
using System.Reflection;

namespace NLayerDotNetCoreApp.Data.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
           .HasKey(ky => new { ky.BookId, ky.AuthorId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ky => ky.Book)
                .WithMany(k => k.Authors)
                .HasForeignKey(ky => ky.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ky => ky.Author)
                .WithMany(y => y.Books)
                .HasForeignKey(ky => ky.AuthorId);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
