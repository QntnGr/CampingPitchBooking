using Web.Entities;

namespace Web.Services;

public interface IBookingService
{
    CookieOptions BuildCookieBooking(Booking item);
}
