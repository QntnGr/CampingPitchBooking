namespace Web.Entities;

public class CampingPitch
{
    public int Id { get; set; }
    public List<Booking>? Bookings {  get; set; }
    public string Label { get; set; }
    public Price? Price { get; set; }
    public string? ImageUrl { get; set; }
    public Localisation? Localisation { get; set; }
    
}
