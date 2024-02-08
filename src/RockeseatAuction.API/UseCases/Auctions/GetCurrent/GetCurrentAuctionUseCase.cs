using RockeseatAuction.API.Contracts;
using RockeseatAuction.API.Entities;

namespace RockeseatAuction.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        private readonly IAuctionRepository _auctionRepository;

        public GetCurrentAuctionUseCase(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }

        public Auction GetAuction()
        {
            return new Auction();
        }
    }
}