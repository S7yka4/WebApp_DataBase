using ElectronicShop.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.Features
{
    public interface IFeaturesManager
    {
        Task<IReadOnlyCollection<Feature>> Output();
        Task<Feature> AddFeature(CreateOrUpdateFeatureRequest tmp);
        Task<Feature> Redact(Guid id, CreateOrUpdateFeatureRequest tmp);
        Task<Feature> Delete(Guid id);
        Task<Feature> GetById(Guid id);
    }
}
