using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using ElectronicShop.Managers.BattaryFeatures;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicShop.Controllers
{
    public class BattaryFeatureController : Controller
    {
        private readonly IBattaryFeatureManager _manager;
        public static Guid Fk;


        public BattaryFeatureController(IBattaryFeatureManager manager)
        {
            _manager=manager;
        }


        public ActionResult Output0(Guid ForeignKey)
        {
            Fk = ForeignKey;
            return RedirectToAction(nameof(Output));
        }


        [HttpGet]
        public async Task<ViewResult> Output()
        {
            var entity = await _manager.Output();
            var tmp = new List<BattaryFeature>();
            foreach (var a in entity)
                if (a.FeatureId == Fk)
                    tmp.Add(a);
            //return View(entity);
            return View(tmp);
        }
        [HttpGet]
        public ViewResult AddNewBattery(Guid ForeignKey)
        {
            Fk = ForeignKey;
            return View(ForeignKey);
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewBattary(string BattaryCapacity, string Voltage,string CurrentOutput)
        {
            var entity = new CreateOrUpdateBattaryFeatureRequest
            {
                id = Guid.NewGuid(),
                 FeatureId = Fk,
                 battaryCapacity = Convert.ToInt32(BattaryCapacity),
                 voltage = Convert.ToDouble(Voltage),
                 currentOutput = Convert.ToInt32(CurrentOutput)
             };
             await _manager.AddToAsort(entity);

            return RedirectToAction(nameof(Output));
        }


        [HttpGet]
        public async Task<ViewResult> RedactBattery(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Redact(Guid Id,Guid FId,string BattaryCapacity, string Voltage, string CurrentOutput)
        {
            var tmp = new CreateOrUpdateBattaryFeatureRequest
            {
                id = Id,
                battaryCapacity = Convert.ToInt32(BattaryCapacity),
                voltage = Convert.ToDouble(Voltage),
                currentOutput = Convert.ToInt32(CurrentOutput),
                FeatureId=FId
            };
            await _manager.Redact(Id, tmp);
            return RedirectToAction(nameof(Output));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteBattery(Guid id)
        {
            var entity = await _manager.Delete(id);
            return RedirectToAction(nameof(Output));
        }



        [HttpGet]
        public async Task<ViewResult> FindByCapacity(string BattaryCapacity)
        {
            var entity = await _manager.Output();
            List<BattaryFeature> tmp= new List<BattaryFeature>();
            foreach (var a in entity)
                if (Convert.ToInt32(BattaryCapacity) == a.battaryCapacity)
                    tmp.Add(a);
            return View(tmp);
        }

        [HttpGet] 
        public async Task<ViewResult> FindByCurrentOutput(string CurrentOutput)
        {
            var entity = await _manager.Output();
            List<BattaryFeature> tmp = new List<BattaryFeature>();
            foreach (var a in entity)
                if (Convert.ToInt32(CurrentOutput) == a.currentOutput)
                    tmp.Add(a);
            return View(tmp);
        }
    }
}