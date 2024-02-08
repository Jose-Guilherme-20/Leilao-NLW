using Microsoft.AspNetCore.Mvc;
using RockeseatAuction.API.Entities;
using RockeseatAuction.API.Repositories;

namespace RockeseatAuction.API.Controllers
{

    public class AuctionController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Get()
        {
            var db = new AppDbContext();
            return Ok(db.Auctions.First());
        }
    }
}