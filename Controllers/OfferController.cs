using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OfferController : ControllerBase
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute] int itemId)
    {
        return Created();
    }

}