namespace Web.Entities;

public class Localisation
{
    public int Id { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
}