using ElectronicShop.Storage;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.ResponsibleConsultants
{
    public class ResponsibleConsultantManager:IResponsibleConsultantManager
    {
        private readonly DevicesDataContext _dbContext;
        private readonly IWebHostEnvironment _hostEnviroment;


        public ResponsibleConsultantManager(DevicesDataContext dbContext, IWebHostEnvironment hostEnviroment)
        {
            _dbContext = dbContext;
            _hostEnviroment = hostEnviroment;

        }

        public async Task<ResponsibleConsultant> AddToAsort(CreateOrUpdateResponsibleConsultantRequest tmp)
        {
            var entity = new ResponsibleConsultant
            {
                id = Guid.NewGuid(),
                name = tmp.name,
                mark = tmp.mark,
                CategoryId=tmp.CategoryId
            };
            _dbContext.ResponsibleConsultants.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IReadOnlyCollection<ResponsibleConsultant>> Output()
        {
            var tmp = _dbContext.ResponsibleConsultants.AsNoTracking();
            var entities = await tmp.ToListAsync();
            return entities;
        }

        public async Task<ResponsibleConsultant> GetById(Guid id)
        {
            return await _dbContext.ResponsibleConsultants.FirstOrDefaultAsync(tmp => tmp.id == id);
        }

        public async Task<ResponsibleConsultant> Redact(Guid id, CreateOrUpdateResponsibleConsultantRequest tmp)
        {
            var entity = await _dbContext.ResponsibleConsultants.FirstOrDefaultAsync(s => s.id == id);
            entity.name = tmp.name;
            entity.mark = tmp.mark;
            entity.CategoryId = tmp.CategoryId;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<ResponsibleConsultant> Delete(Guid id)
        {
            var entity = await _dbContext.ResponsibleConsultants.FirstOrDefaultAsync(s => s.id == id);
            _dbContext.ResponsibleConsultants.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

    }
}
