using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RockeseatAuction.API.Communication.Requests;
using RockeseatAuction.API.Filters;
using RockeseatAuction.API.UseCases.Auctions.Offers.CreateOffer;

namespace RockeseatAuction.API.Controllers
{

    public class OfferController : BaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        [ServiceFilter(typeof(AuthenticationUserAttribute))]
        public async Task<IActionResult> CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
        {
            var id = useCase.Execute(itemId, request);
            return Created(string.Empty, id);
        }
    }
}