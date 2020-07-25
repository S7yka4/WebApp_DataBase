using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicShop.Managers.Devices;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicShop.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceManager _manager;
        public static Guid Fk;

        public DeviceController(IDeviceManager manager)
        {
            _manager = manager;
        }


        public async Task<ViewResult> Output()
        {
            var entity = await _manager.Output();
            List<Device> tmp = new List<Device>();
            foreach (var a in entity)
                tmp.Add(a);
            return View(tmp);
        }
       
        public ViewResult AddNewDevice()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewDevice(string Name, string Count)
        {
            var entity = new CreateOrUpdateDeviceRequest
            {
                id = Guid.NewGuid(),
                name = Name,
                count = Convert.ToInt32(Count)
            };
            await _manager.AddDevice(entity);
            return RedirectToAction(nameof(Output));
        }




        [HttpGet]
        public async Task<ViewResult> RedactDevice(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }


        [HttpPost]
        public async Task<ActionResult> Redact(Guid Id, string Name, string Count)
        {
            var tmp = new CreateOrUpdateDeviceRequest
            {
                id = Id,
                name = Name,
                count = Convert.ToInt32(Count),
            };
            await _manager.Redact(Id, tmp);
            return RedirectToAction(nameof(Output));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteDevice(Guid id)
        {
            var entity = await _manager.Delete(id);
            return RedirectToAction(nameof(Output));
        }
    }

  
}