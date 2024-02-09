using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockeseatAuction.API.Communication.Requests;
using RockeseatAuction.API.Entities;

namespace RockeseatAuction.API.Contracts
{
    public interface IOfferRepository
    {
        Offer CreateOffer(int itemId, int userId, RequestCreateOfferJson request);
    }
}