 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicShop.Managers.Features;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace ElectronicShop.Controllers
{
    public class FeatureController : Controller
    {

        private readonly IFeaturesManager _manager;
        public static Guid Fk;

        public FeatureController(IFeaturesManager manager)
        {
            _manager = manager;
        }
        

        public ActionResult Output0(Guid ForeignKey)
        {
            Fk = ForeignKey;
            return RedirectToAction(nameof(Output));
        }
       
        public async Task<ViewResult> Output()
        {
            var entity = await _manager.Output();
            var tmp = new List<Feature>();
            foreach (var a in entity)
                if (a.DeviceId == Fk)
                    tmp.Add(a);
            return View(tmp);
            //return View(entity);
        }


        [HttpGet]
        public ViewResult AddNewFeature(Guid ForeignKey)
        {
            Fk = ForeignKey;
            return View(Fk);
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewFeature(string warrantyDuration, string Weight, String Power)
        {
            var entity = new CreateOrUpdateFeatureRequest
            {
                id = Guid.NewGuid(),
                DeviceId = Fk,
                warrantyduration = Convert.ToInt32(warrantyDuration),
                power=Convert.ToDouble(Power),
                weight = Convert.ToDouble(Weight)
                
            };
            await _manager.AddFeature(entity);
            return RedirectToAction(nameof(Output));
        }

  


        [HttpGet]
        public async Task<ViewResult> RedactFeature(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }


        [HttpPost]
        public async Task<ActionResult> Redact(Guid Id,Guid FId, string WarrantyDuration,string Weight,string Power)
        {
            var tmp = new CreateOrUpdateFeatureRequest
            {
                id = Id,
                warrantyduration = Convert.ToDouble(WarrantyDuration),
                weight = Convert.ToDouble(Weight),
                power=Convert.ToDouble(Power),
                DeviceId=FId
            };
            await _manager.Redact(Id, tmp);
            return RedirectToAction(nameof(Output));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteFeature(Guid id)
        {
            var entity = await _manager.Delete(id);
            return RedirectToAction(nameof(Output));
        }



       
    }
}