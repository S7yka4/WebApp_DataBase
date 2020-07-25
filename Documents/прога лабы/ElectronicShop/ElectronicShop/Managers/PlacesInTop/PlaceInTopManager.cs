using ElectronicShop.Storage;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.PlacesInTop
{
    public class PlaceInTopManager:IPlaceInTopManager
    {
        private readonly DevicesDataContext _dbContext;
        private readonly IWebHostEnvironment _hostEnviroment;


        public PlaceInTopManager(DevicesDataContext dbContext, IWebHostEnvironment hostEnviroment)
        {
            _dbContext = dbContext;
            _hostEnviroment = hostEnviroment;
        }

        public async Task<PlaceInTop> AddToAsort(CreateOrUpdatePlaceInTopRequest tmp)
        {
            var entity = new PlaceInTop
            {
                id = Guid.NewGuid(),
                middleAge = tmp.middleAge,
                highAge = tmp.highAge,
                lowAge = tmp.lowAge,
                CategoryId=tmp.CategoryId
            };
            _dbContext.PlacesInTop.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IReadOnlyCollection<PlaceInTop>> Output()
        {
            var tmp = _dbContext.PlacesInTop.AsNoTracking();
            var entity = await tmp.ToListAsync();
            return entity;

        }

        public async Task<PlaceInTop> GetById(Guid id)
        {
            return await _dbContext.PlacesInTop.FirstOrDefaultAsync(tmp => tmp.id == id);
        }

        public async Task<PlaceInTop> Redact(Guid id, CreateOrUpdatePlaceInTopRequest tmp)
        {
            var entity = await _dbContext.PlacesInTop.FirstOrDefaultAsync(s => s.id == id);
            entity.middleAge = tmp.middleAge;
            entity.lowAge = tmp.lowAge;
            entity.highAge = tmp.highAge;
            entity.CategoryId = tmp.CategoryId;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<PlaceInTop> Delete(Guid id)
        {
            var entity = await _dbContext.PlacesInTop.FirstOrDefaultAsync(s => s.id == id);
            _dbContext.PlacesInTop.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

    }
}
