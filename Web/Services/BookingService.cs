using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Web.Entities;
using Web.Helpers;
using Web.Infrastructure;

namespace Web.Services
{
    public class BookingService : IBookingService
    {
        IHttpContextAccessor _httpContextAccessor;
        public BookingService(IHttpContextAccessor httpContextAccessor) 
        {
            _httpContextAccessor = httpContextAccessor;        
        }

        public OkObjectResult AddCookieBooking(Booking item)
        {
            var options =  new CookieOptions
            {
                Domain = "Booking",
                Path = "/",
                HttpOnly = false,
                Secure = false,
                Expires = DateTime.Now.AddHours(1) // Définir la durée de vie du cookie
            };

            var cookieValue = JsonSerializer.Serialize(item);
            _httpContextAccessor.HttpContext.Response.Cookies.Append(Constants.BookingCookiesName, cookieValue, options);

            return new OkObjectResult("Cookie Booking added.");
        }

    }
}
