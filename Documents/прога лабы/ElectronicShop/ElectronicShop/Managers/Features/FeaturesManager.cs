using ElectronicShop.Storage;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.Features
{
    public class FeaturesManager : IFeaturesManager
    {
        private readonly DevicesDataContext _dbContext;
        private readonly IWebHostEnvironment _hostEnviroment;


        public FeaturesManager(DevicesDataContext dbContext, IWebHostEnvironment hostEnviroment)
        {
            _dbContext = dbContext;
            _hostEnviroment = hostEnviroment;

        }

        public async Task<Feature> AddFeature(CreateOrUpdateFeatureRequest tmp)
        {
            var entity = new Feature
            {
                id = Guid.NewGuid(),
                warrantyduration = tmp.warrantyduration,
                weight = tmp.weight,
                power=tmp.power,
                DeviceId=tmp.DeviceId
            };
             _dbContext.Features.Add(entity);
            await _dbContext.SaveChangesAsync();//асинхронно сохранили изменения без нее девайс останется в контексте
            return entity;
        }

        public async Task<Feature> Redact(Guid id, CreateOrUpdateFeatureRequest tmp)
        {
            var entity = await _dbContext.Features.FirstOrDefaultAsync(s => s.id == id);
            entity.warrantyduration = tmp.warrantyduration;
            entity.weight = tmp.weight;
            entity.DeviceId = tmp.DeviceId;
            entity.power = tmp.power;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IReadOnlyCollection<Feature>> Output()
        {
            var tmp = _dbContext.Features
                                .AsNoTracking();
            var entities = await tmp.ToListAsync();
            return entities;
        }



        public async Task<Feature> Delete(Guid id)
        {
            var entity = await _dbContext.Features.FirstOrDefaultAsync(s => s.id == id);
            _dbContext.Features.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Feature> GetById(Guid id)
        {
            return await _dbContext.Features.FirstOrDefaultAsync(tmp => tmp.id == id);
        }
    }
}
