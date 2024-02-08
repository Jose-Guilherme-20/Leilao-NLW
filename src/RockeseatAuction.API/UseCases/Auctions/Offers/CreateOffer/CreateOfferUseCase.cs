using RockeseatAuction.API.Communication.Requests;
using RockeseatAuction.API.Entities;
using RockeseatAuction.API.Repositories;
using RockeseatAuction.API.Services;

namespace RockeseatAuction.API.UseCases.Auctions.Offers.CreateOffer
{
    public class CreateOfferUseCase
    {
        private readonly LoggedUser _loggedUser;

        public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;

        public int Execute(int itemId, RequestCreateOfferJson request)
        {
            var repository = new AppDbContext();
            var user = _loggedUser.User();
            var offer = new Offer
            {
                CreateOn = DateTime.Now,
                ItemId = itemId,
                Price = request.Price,
                UserId = user.Id
            };

            repository.Offers.Add(offer);
            repository.SaveChanges();

            return offer.Id;
        }
    }
}