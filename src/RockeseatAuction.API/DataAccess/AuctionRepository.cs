using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RockeseatAuction.API.Contracts;
using RockeseatAuction.API.Entities;
using RockeseatAuction.API.Repositories;

namespace RockeseatAuction.API.DataAccess
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly AppDbContext _dbContext;

        public AuctionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Auction? GetCurrent()
        {
            var today = DateTime.Now;

            return _dbContext
            .Auctions
            .Include(x => x.Items)
            .AsNoTracking()
            .FirstOrDefault(x => today >= x.Starts && today <= x.Ends);
        }
    }
}