using Microsoft.EntityFrameworkCore;

namespace MyFirstEFCoreApp
{
    class AppDbContext : DbContext
    {
        private const string ConnectionString =
            @"Server=TIENPC\SQLEXPRESS; Database=MyFirstEFCoreDb; Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; }
    }
}