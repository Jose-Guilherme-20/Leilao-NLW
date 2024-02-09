using Microsoft.AspNetCore.Mvc;
using RockeseatAuction.API.Entities;
using RockeseatAuction.API.Repositories;
using RockeseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RockeseatAuction.API.Controllers
{

    public class AuctionController : BaseController
    {
        private readonly GetCurrentAuctionUseCase _getCurrentAuctionUseCase;

        public AuctionController(GetCurrentAuctionUseCase getCurrentAuctionUseCase)
        {
            _getCurrentAuctionUseCase = getCurrentAuctionUseCase;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get()
        {
            return Ok(_getCurrentAuctionUseCase.GetAuction());
        }
    }
}