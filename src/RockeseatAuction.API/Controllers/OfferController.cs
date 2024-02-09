using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RockeseatAuction.API.Communication.Requests;
using RockeseatAuction.API.Filters;
using RockeseatAuction.API.UseCases.Auctions.Offers.CreateOffer;

namespace RockeseatAuction.API.Controllers
{

    public class OfferController : BaseController
    {
        private readonly CreateOfferUseCase _createOfferUseCase;

        public OfferController(CreateOfferUseCase createOfferUseCase)
        {
            _createOfferUseCase = createOfferUseCase;
        }

        [HttpPost]
        [Route("{itemId}")]
        [ServiceFilter(typeof(AuthenticationUserAttribute))]
        public async Task<IActionResult> CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request)
        {
            var id = _createOfferUseCase.Execute(itemId, request);
            return Created(string.Empty, id);
        }
    }
}