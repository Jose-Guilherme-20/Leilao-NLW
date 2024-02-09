using Microsoft.EntityFrameworkCore;
using RockeseatAuction.API.Entities;

namespace RockeseatAuction.API.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }

    }
}