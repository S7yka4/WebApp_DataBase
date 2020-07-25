using ElectronicShop.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.Devices
{
    public interface IDeviceManager
    {

        Task<IReadOnlyCollection<Device>> Output();
        Task<Device> AddDevice(CreateOrUpdateDeviceRequest tmp);
        Task<Device> Redact(Guid id, CreateOrUpdateDeviceRequest tmp);
        Task<Device> Delete(Guid id);
        Task<Device> GetById(Guid id);
    }
}
