using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicShop.Managers.Costs;
using ElectronicShop.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicShop.Controllers
{
    public class CostController : Controller
    {
        private readonly ICostManager _manager;
        public static Guid Fk;

        public CostController(ICostManager manager)
        {
            _manager = manager;
        }

        public ActionResult Output0(Guid ForeignKey)
        {
            Fk = ForeignKey;
            return RedirectToAction(nameof(Output));
        }

        [HttpGet]
        public async Task<ActionResult> Output()
        {
            var entity = await _manager.Output();
            List<Cost> tmp = new List<Cost>();
            foreach (var a in entity)
                if (a.DeviceId == Fk)
                    tmp.Add(a);
            return View(entity);
        }



        [HttpGet]
        public ViewResult AddNewCost(Guid ForeignKey)
        {
            Fk = ForeignKey;
            return View(ForeignKey);
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewCost(string CostInDollars, string CostInRub)
        {
            var entity = new CreateOrUpdateCostRequest
            {
                id = Guid.NewGuid(),
                DeviceId = Fk,
                costInDollars = Convert.ToDouble(CostInDollars),
                costInRub = Convert.ToDouble(CostInRub)
            };
            await _manager.AddToAsort(entity);

            return RedirectToAction(nameof(Output));
        }


        [HttpGet]
        public async Task<ViewResult> RedactCost(Guid id)
        {
            var entity = await _manager.GetById(id);
            
            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Redact(Guid Id, Guid FId, string CostInDollars, string CostInRub)
        {
            var tmp = new CreateOrUpdateCostRequest
            {
                id = Id,
                costInDollars = Convert.ToDouble(CostInDollars),
                costInRub = Convert.ToDouble(CostInRub),
                DeviceId = FId
            };
            await _manager.Redact(Id, tmp);
            return RedirectToAction(nameof(Output));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteCost(Guid id)
        {
            var entity = await _manager.Delete(id);
            return RedirectToAction(nameof(Output));
        }



        [HttpGet]
        public async Task<ViewResult> FindByDollar(string CostInDollars)
        {
            var entity = await _manager.Output();
            List<Cost> tmp = new List<Cost>();
            foreach (var a in entity)
                if (Convert.ToInt32(CostInDollars) == a.costInDollars)
                    tmp.Add(a);
            return View(tmp);
        }

        [HttpGet]
        public async Task<ViewResult> FindByRub(string CostInRub)
        {
            var entity = await _manager.Output();
            List<Cost> tmp = new List<Cost>();
            foreach (var a in entity)
                if (Convert.ToInt32(CostInRub) == a.costInRub)
                    tmp.Add(a);
            return View(tmp);
        }
    }
}