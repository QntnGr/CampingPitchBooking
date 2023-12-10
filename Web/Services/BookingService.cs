using Web.Entities;
using Web.Infrastructure;

namespace Web.Services
{
    public class BookingService : IBookingService
    {
        CatalogContext _dbContext;
        public BookingService(CatalogContext catalogContext) 
        { 
            _dbContext = catalogContext;        
        }

        public CookieOptions BuildCookieBooking(Booking item)
        {
            return new CookieOptions
            {
                Domain = "Booking",
                Path = "/",
                HttpOnly = false,
                Secure = false,
                Expires = DateTime.Now.AddHours(1) // Définir la durée de vie du cookie
            };
        }

    }
}
