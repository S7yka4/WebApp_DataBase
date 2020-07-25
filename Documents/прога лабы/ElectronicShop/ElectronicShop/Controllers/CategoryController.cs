using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicShop.Managers.Categories;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryManager _manager;
        public static Guid Fk;
        public CategoryController(ICategoryManager manager)
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

        public ViewResult AddNewCategory(Guid ForeignKey)
        {
            Fk = ForeignKey;
            return View(Fk);
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewCategory(string NameOfCategory)
        {
            var entity = new CreateOrUpdateCategoryRequest
            {
                id = Guid.NewGuid(),
                nameofcategory = NameOfCategory,
                DeviceId = Fk
            };
            await _manager.AddToAsort(entity);
            return RedirectToAction(nameof(Output));
        }




        [HttpGet]
        public async Task<ViewResult> RedactCategory(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }


        [HttpPost]
        public async Task<ActionResult> Redact(Guid Id,Guid FId, string NameOfCategory)
        {
            var tmp = new CreateOrUpdateCategoryRequest
            {
                id = Id,
                nameofcategory= NameOfCategory,
                DeviceId = FId
            };
            await _manager.Redact(Id, tmp);
            return RedirectToAction(nameof(Output));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteCategory(Guid id)
        {
            var entity = await _manager.Delete(id);
            return RedirectToAction(nameof(Output));
        }
    }
}