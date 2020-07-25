using ElectronicShop.Storage;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.Costs
{
    public class CostManager:ICostManager
    {
        private readonly DevicesDataContext _dbContext;
        private readonly IWebHostEnvironment _hostEnviroment;


        public CostManager(DevicesDataContext dbContext, IWebHostEnvironment hostEnviroment)
        {
            _dbContext = dbContext;
            _hostEnviroment = hostEnviroment;
        }

        public async Task<Cost> AddToAsort(CreateOrUpdateCostRequest tmp)
        {
            var entity = new Cost
            {
                id = Guid.NewGuid(),
                costInRub=tmp.costInRub,
                costInDollars=tmp.costInDollars,
                DeviceId = tmp.DeviceId
            };
            _dbContext.Costs.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IReadOnlyCollection<Cost>> Output()
        {
            var tmp = _dbContext.Costs.AsNoTracking();
            var entities = await tmp.ToListAsync();
            return entities;
        }

        public async Task<Cost> GetById(Guid id)
        {
            return await _dbContext.Costs.FirstOrDefaultAsync(tmp => tmp.id == id);
        }

        public async Task<Cost> Redact(Guid id, CreateOrUpdateCostRequest tmp)
        {
            var entity = await _dbContext.Costs.FirstOrDefaultAsync(s => s.id == id);
            entity.costInDollars = tmp.costInDollars;
            entity.costInRub = tmp.costInRub;
            entity.DeviceId = tmp.DeviceId;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Cost> Delete(Guid id)
        {
            var entity = await _dbContext.Costs.FirstOrDefaultAsync(s => s.id == id);
            _dbContext.Costs.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<Cost> GetByDollar(Double CostInDollars)
        {
            var entity = await _dbContext.Costs.FirstOrDefaultAsync(s => s.costInDollars == CostInDollars);
            return entity;
        }

        public async Task<Cost> GetByRub(Double CostInRub)
        {
            var entity = await _dbContext.Costs.FirstOrDefaultAsync(s => s.costInRub == CostInRub);
            return entity;
        }
    }
}




