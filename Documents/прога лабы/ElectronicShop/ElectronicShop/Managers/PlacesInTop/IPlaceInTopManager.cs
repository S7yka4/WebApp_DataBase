using ElectronicShop.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.PlacesInTop
{
    public interface IPlaceInTopManager
    {
        Task<PlaceInTop> Delete(Guid id);
        Task<PlaceInTop> AddToAsort(CreateOrUpdatePlaceInTopRequest tmp);
        Task<IReadOnlyCollection<PlaceInTop>> Output();
        Task<PlaceInTop> GetById(Guid id);
        Task<PlaceInTop> Redact(Guid id, CreateOrUpdatePlaceInTopRequest tmp);
    }
}
