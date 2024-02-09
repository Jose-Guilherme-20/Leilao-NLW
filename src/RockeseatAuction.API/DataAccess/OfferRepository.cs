using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockeseatAuction.API.Communication.Requests;
using RockeseatAuction.API.Contracts;
using RockeseatAuction.API.Entities;
using RockeseatAuction.API.Repositories;
using RockeseatAuction.API.Services;

namespace RockeseatAuction.API.DataAccess
{
    public class OfferRepository : IOfferRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly LoggedUser _loggedUser;

        public OfferRepository(AppDbContext appDbContext, LoggedUser loggedUser)
        {
            _appDbContext = appDbContext;
        }

        public Offer CreateOffer(int itemId, int userId, RequestCreateOfferJson request)
        {
            var offer = new Offer
            {
                CreateOn = DateTime.Now,
                ItemId = itemId,
                Price = request.Price,
                UserId = userId
            };
            _appDbContext.Offers.Add(offer);
            _appDbContext.SaveChanges();
            return offer;

        }
    }
}