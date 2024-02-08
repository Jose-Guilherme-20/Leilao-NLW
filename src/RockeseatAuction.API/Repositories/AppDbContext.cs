using Microsoft.EntityFrameworkCore;
using RockeseatAuction.API.Entities;

namespace RockeseatAuction.API.Repositories
{
    public class AppDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\jgsco\\Documents\leilaoDbNLW.db");
        }
    }
}