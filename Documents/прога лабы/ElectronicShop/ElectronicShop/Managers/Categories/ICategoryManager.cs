using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicShop.Storage.Entity;

namespace ElectronicShop.Managers.Categories
{
    public interface ICategoryManager
    {
        Task<IReadOnlyCollection<Category>> Output();
        Task<Category> AddToAsort(CreateOrUpdateCategoryRequest tmp);
        Task<Category> Redact(Guid id, CreateOrUpdateCategoryRequest tmp);
        Task<Category> Delete(Guid id);
        Task<Category> GetById(Guid id);
    }
}
