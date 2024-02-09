using RockeseatAuction.API.Communication.Requests;
using RockeseatAuction.API.Contracts;
using RockeseatAuction.API.Entities;
using RockeseatAuction.API.Repositories;
using RockeseatAuction.API.Services;

namespace RockeseatAuction.API.UseCases.Auctions.Offers.CreateOffer
{
    public class CreateOfferUseCase
    {
        private readonly LoggedUser _loggedUser;
        private readonly IOfferRepository _offerRepository;

        public CreateOfferUseCase(LoggedUser loggedUser, IOfferRepository offerRepository)
        {
            _loggedUser = loggedUser;
            _offerRepository = offerRepository;
        }

        public int Execute(int itemId, RequestCreateOfferJson request)
        {
            var user = _loggedUser.User();
            var create = _offerRepository.CreateOffer(itemId, user.Id, request);

            return create.Id;
        }
    }
}