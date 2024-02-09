using Moq;
using NlW.UseCases.Unit.Test.Mocks;
using RockeseatAuction.API.Contracts;
using RockeseatAuction.API.Entities;
using RockeseatAuction.API.UseCases.Auctions.GetCurrent;
using Xunit;

namespace NlW.UseCases.Unit.Test.UseCases
{
    public class GetCurrentTest
    {
        private readonly Mock<IAuctionRepository> _auctionRepositoryMock;

        public GetCurrentTest()
        {
            _auctionRepositoryMock = new Mock<IAuctionRepository>();
        }
        private GetCurrentAuctionUseCase GetCurrent()
        {
            return new GetCurrentAuctionUseCase(_auctionRepositoryMock.Object);
        }

        [Fact]
        public void GetCurrent_ReturnSucess()
        {
            //Arrange
            var auction = AuctionMock.AuctionFaker.Generate();
            _auctionRepositoryMock.Setup(s => s.GetCurrent()).Returns(auction);

            var getCurrent = GetCurrent();
            //Act
            var result = getCurrent.GetAuction();
            //Assert
            Assert.NotNull(result);
            Assert.IsType<Auction>(result);
        }
    }
}