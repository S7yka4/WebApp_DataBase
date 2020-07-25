using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicShop.Storage;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace ElectronicShop.Managers.Categories
{
    public class CategoryManager:ICategoryManager
    {
        private readonly DevicesDataContext _dbContext;
        private readonly IWebHostEnvironment _hostEnviroment;


        public CategoryManager(DevicesDataContext dbContext, IWebHostEnvironment hostEnviroment)
        {
            _dbContext = dbContext;
            _hostEnviroment = hostEnviroment;

        }

        public async Task<Category> AddToAsort(CreateOrUpdateCategoryRequest tmp)
        {
            var entity = new Category
            {
                id = Guid.NewGuid(),
                nameofcategory = tmp.nameofcategory,
                DeviceId = tmp.DeviceId
            };
            _dbContext.Categories.Add(entity);
            await _dbContext.SaveChangesAsync();//асинхронно сохранили изменения без нее девайс останется в контексте
            return entity;
        }

        public async Task<IReadOnlyCollection<Category>> Output()
        {
            var tmp = _dbContext.Categories
                                .AsNoTracking();
            var entities = await tmp.ToListAsync();
            return entities;
        }

        public async Task<Category> Redact(Guid id, CreateOrUpdateCategoryRequest tmp)
        {
            var entity = await _dbContext.Categories.FirstOrDefaultAsync(s => s.id == id);
            entity.nameofcategory = tmp.nameofcategory;
            entity.DeviceId = tmp.DeviceId;
            await _dbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<Category> Delete(Guid id)
        {
            var entity = await _dbContext.Categories.FirstOrDefaultAsync(s => s.id == id);
            _dbContext.Categories.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Category> GetById(Guid id)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(tmp => tmp.id == id);
        }
    }
}
