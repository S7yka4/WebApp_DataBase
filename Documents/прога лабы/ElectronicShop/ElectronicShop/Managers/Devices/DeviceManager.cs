using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ElectronicShop.Storage;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace ElectronicShop.Managers.Devices
{
    public class DeviceManager : IDeviceManager
    {
        private readonly DevicesDataContext _dbContext;
        private readonly IWebHostEnvironment _hostEnviroment;

        
        public DeviceManager(DevicesDataContext dbContext,IWebHostEnvironment hostEnviroment)
        {
            _dbContext = dbContext;
            _hostEnviroment = hostEnviroment;

        }

        public async Task<Device> AddDevice(CreateOrUpdateDeviceRequest tmp)
        {
            var entity = new Device
            {
                id = Guid.NewGuid(),
                name = tmp.name,
                count = tmp.count,
            };
            _dbContext.Devices.Add(entity);
            await _dbContext.SaveChangesAsync();//асинхронно сохранили изменения без нее девайс останется в контексте
            return entity;
        }

        public async Task<IReadOnlyCollection<Device>> Output()
        {
            var tmp = _dbContext.Devices
                                .AsNoTracking();
            var entities = await tmp.ToListAsync();
            return entities;
            
        }


  

        public async Task<Device> Redact(Guid id, CreateOrUpdateDeviceRequest tmp)
        {
            var entity = await _dbContext.Devices.FirstOrDefaultAsync(s => s.id == id);
            entity.name= tmp.name;
            entity.count = tmp.count;
            await _dbContext.SaveChangesAsync();
            return entity;
        }



        public async Task<Device> Delete(Guid id)
        {
            var entity = await _dbContext.Devices.FirstOrDefaultAsync(s => s.id == id);
            _dbContext.Devices.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Device> GetById(Guid id)
        {
            return await _dbContext.Devices.FirstOrDefaultAsync(tmp => tmp.id == id);
        }
    }
}
