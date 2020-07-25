using ElectronicShop.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.BattaryFeatures
{
    public interface IBattaryFeatureManager
    {
        Task<BattaryFeature> Delete(Guid id);
        Task<BattaryFeature> AddToAsort(CreateOrUpdateBattaryFeatureRequest tmp);
        Task<IReadOnlyCollection<BattaryFeature>> Output();
        Task<BattaryFeature> GetById(Guid id);
        Task<BattaryFeature>  Redact(Guid id, CreateOrUpdateBattaryFeatureRequest tmp);
        Task<BattaryFeature> GetByCapacity(int BattaryCapacity);
    }
}
