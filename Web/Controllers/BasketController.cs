using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Web.Entities;
using Web.Helpers;
using Web.Services;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class BasketController : ControllerBase
{

    private readonly ILogger<HomeController> _logger;
    private readonly IBookingService _bookingService;

    public BasketController(ILogger<HomeController> logger, IBookingService bookingService)
    {
        _logger = logger;
        _bookingService = bookingService;
    }

    [HttpPost]
    [ProducesResponseType(typeof(OkObjectResult), 200)]
    [ProducesResponseType(403)]
    public OkObjectResult AddToBasket(Booking booking)
    {
        return _bookingService.AddCookieBooking(booking);
    }

    [HttpGet]
    [ProducesResponseType(typeof(Booking), 200)]
    [ProducesResponseType(403)]
    public Booking GetBasketCookie()
    {
        if (Request.Cookies.TryGetValue(Constants.BookingCookiesName, out var valeurDuCookie))
        {
            return JsonSerializer.Deserialize<Booking>(valeurDuCookie);
        }
        return null;
    }
}
