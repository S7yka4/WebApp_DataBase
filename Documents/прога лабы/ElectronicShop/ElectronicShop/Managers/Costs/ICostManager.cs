using ElectronicShop.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.Costs
{
    public interface ICostManager
    {
        Task<Cost> Delete(Guid id);
        Task<Cost> AddToAsort(CreateOrUpdateCostRequest tmp);
        Task<IReadOnlyCollection<Cost>> Output();
        Task<Cost> GetById(Guid id);
        Task<Cost> Redact(Guid id, CreateOrUpdateCostRequest tmp);
        Task<Cost> GetByDollar(double CostIndollars);
    }
}
