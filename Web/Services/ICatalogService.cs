using Web.Entities;

namespace Web.Services;

public interface ICatalogService
{
    void Insert(CampingPitch item);
    List<CampingPitch> GetAll();
}
