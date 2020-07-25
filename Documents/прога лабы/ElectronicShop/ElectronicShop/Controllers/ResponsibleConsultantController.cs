using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicShop.Managers.ResponsibleConsultants;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicShop.Controllers
{
    public class ResponsibleConsultantController : Controller
    {
        private readonly IResponsibleConsultantManager _manager;
        public static Guid Fk;

        public ResponsibleConsultantController(IResponsibleConsultantManager manager)
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
            var tmp =await _manager.Output();
            return View(tmp);
        }

        [HttpGet]
        public ViewResult AddNewResponsibleConsultant(Guid ForeignKey)
        {
            Fk = ForeignKey;
            return View(ForeignKey);
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewResponsibleConsultant(string Mark, string Name)
        {
            var entity = new CreateOrUpdateResponsibleConsultantRequest
            {
                id = Guid.NewGuid(),
                CategoryId=Fk,
                mark = Convert.ToDouble(Mark),
                name = Name
            };
            await _manager.AddToAsort(entity);

            return RedirectToAction(nameof(Output));
        }


        [HttpGet]
        public async Task<ViewResult> RedactResponsibleConsultant(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Redact(Guid Id, Guid FId, string Mark, string Name)
        {
            var tmp = new CreateOrUpdateResponsibleConsultantRequest
            {
                id = Id,
                name = Name,
                mark = Convert.ToDouble(Mark),
                CategoryId = FId
            };
            await _manager.Redact(Id, tmp);
            return RedirectToAction(nameof(Output));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteResponsibleConsultant(Guid id)
        {
            var entity = await _manager.Delete(id);
            return RedirectToAction(nameof(Output));
        }
    }
}