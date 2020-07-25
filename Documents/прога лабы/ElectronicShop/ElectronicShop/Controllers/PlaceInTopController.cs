using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicShop.Managers.PlacesInTop;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicShop.Controllers
{
    public class PlaceInTopController : Controller
    {
        private readonly IPlaceInTopManager _manager;
        public static Guid Fk;
        public PlaceInTopController(IPlaceInTopManager manager)
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
            return View(entity);
        }

  


 
        [HttpGet]
        public ViewResult AddNewplaceInTop(Guid ForeignKey)
        {
            Fk = ForeignKey;
            return View(ForeignKey);
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewPlaceInTop(string MiddleAge, string HighAge, string LowAge)
        {
            var entity = new CreateOrUpdatePlaceInTopRequest
            {
                id = Guid.NewGuid(),
                CategoryId = Fk,
                lowAge= Convert.ToInt32(LowAge),
                highAge = Convert.ToInt32(HighAge),
                middleAge = Convert.ToInt32(MiddleAge)
            };
            await _manager.AddToAsort(entity);

            return RedirectToAction(nameof(Output));
        }


        [HttpGet]
        public async Task<ViewResult> RedactPlaceInTop(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Redact(Guid Id, Guid FId, string MiddleAge, string HighAge, string LowAge)
        {
            var tmp = new CreateOrUpdatePlaceInTopRequest
            {
                id = Id,
                lowAge = Convert.ToInt32(LowAge),
                highAge = Convert.ToInt32(HighAge),
                middleAge = Convert.ToInt32(MiddleAge),
                CategoryId = FId
            };
            await _manager.Redact(Id, tmp);
            return RedirectToAction(nameof(Output));
        }

        [HttpGet]
        public async Task<ActionResult> DeletePlaceInTop(Guid id)
        {
            var entity = await _manager.Delete(id);
            return RedirectToAction(nameof(Output));
        }

    }
}