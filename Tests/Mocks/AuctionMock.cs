using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using RockeseatAuction.API.Entities;

namespace NlW.UseCases.Unit.Test.Mocks
{
    public static class AuctionMock
    {
        public static Faker<Auction> AuctionFaker =>
        new Faker<Auction>("pt_BR")
        .CustomInstantiator(x => new Auction
        {
            Id = x.Random.Int(1, 10),
            Starts = x.Date.Past(),
            Ends = x.Date.Future(),
            Name = x.Name.FirstName(),
        });


    }
}