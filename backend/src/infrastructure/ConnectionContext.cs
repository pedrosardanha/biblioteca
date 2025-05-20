using backend.src.models;
using Microsoft.EntityFrameworkCore;

namespace backend.src.infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseNpgsql(
                "Server=postgres;" +
                "Port=5432; Database=db_frotas;" +
                "User Id=root;" +
                "Password=root"
            );
    }
}

