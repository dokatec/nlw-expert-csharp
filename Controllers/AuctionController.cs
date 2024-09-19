using Microsoft.AspNetCore.Mvc;

namespace Auction.Controllers;

[Route("[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCurrentAuction()
    {
        return NotFound("Jhonatan Pacheco");
    }

}