using Microsoft.AspNetCore.Mvc;
using Web.Entities;

namespace Web.Services;

public interface IBookingService
{
    OkObjectResult AddCookieBooking(Booking item);
}
