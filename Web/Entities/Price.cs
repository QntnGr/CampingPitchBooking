using Microsoft.EntityFrameworkCore;

namespace Web.Entities;


public class Price
{
    public int Id { get; set; }
    public decimal TTC { get; set; }
}