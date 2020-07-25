using ElectronicShop.Storage;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.BattaryFeatures
{
    public class BattaryFeatureManager : IBattaryFeatureManager
    {
        private readonly DevicesDataContext _dbContext;
        private readonly IWebHostEnvironment _hostEnviroment;


        public BattaryFeatureManager(DevicesDataContext dbContext, IWebHostEnvironment hostEnviroment)
        {
            _dbContext = dbContext;
            _hostEnviroment = hostEnviroment;
        }

        public async Task<BattaryFeature> AddToAsort(CreateOrUpdateBattaryFeatureRequest tmp)
        {
            var entity = new BattaryFeature
            {
                id = Guid.NewGuid(),
                battaryCapacity = tmp.battaryCapacity,
                voltage = tmp.voltage,
                currentOutput = tmp.currentOutput,
                FeatureId = tmp.FeatureId
            };
            _dbContext.BattaryFeatures.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<BattaryFeature> GetById(Guid id)
        {
            return await _dbContext.BattaryFeatures.FirstOrDefaultAsync(tmp => tmp.id == id);
        }

        public async Task<BattaryFeature> Redact(Guid id, CreateOrUpdateBattaryFeatureRequest tmp)
        {
            var entity = await _dbContext.BattaryFeatures.FirstOrDefaultAsync(s => s.id == id);
            entity.battaryCapacity = tmp.battaryCapacity;
            entity.voltage = tmp.voltage;
            entity.currentOutput = tmp.currentOutput;
            entity.FeatureId = tmp.FeatureId;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<BattaryFeature> Delete(Guid id)
        {
            var entity=await _dbContext.BattaryFeatures.FirstOrDefaultAsync(s => s.id == id);
            _dbContext.BattaryFeatures.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IReadOnlyCollection<BattaryFeature>> Output()
        {
            var tmp = _dbContext.BattaryFeatures.AsNoTracking();
            var entities = await tmp.ToListAsync();
            return entities;
        }

        public async Task<BattaryFeature> GetByCapacity(int BattaryCapacity)
        {
            var entity = await _dbContext.BattaryFeatures.FirstOrDefaultAsync(s => s.battaryCapacity == BattaryCapacity);
            return entity;
        }
    }
}
