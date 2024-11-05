using API.Entities;
using API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.UseCase.Auctions.GetCurrent;


public class GetCurrentAuctionUseCase
{

    public Auction? Execute()
    {
        var repository = new ApiDbContext();

        var today = DateTime.Now;

        return repository
        .Auctions
        .Include(auction => auction.Items)
        .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }

}