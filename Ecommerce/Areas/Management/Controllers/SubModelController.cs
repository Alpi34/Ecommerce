using Ecommerce.Areas.Management.Models.Context;
using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Areas.Management.Controllers
{
    public class SubModelController : Controller
    {
        SubModelRepository SMR = new SubModelRepository(new Models.Context.ApplicationDbContext());
        ModelRepository MR = new ModelRepository(new Models.Context.ApplicationDbContext());
        BrandRepository BR = new BrandRepository(new Models.Context.ApplicationDbContext());


        public ActionResult Index()
        {
            return View(SMR.getAll());
        }
        [HttpPost]
        public ActionResult getModels (int brandId)
        {
            return Json(MR.GetAll (brandId), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getSubModels(int modelId)
        {
            return Json(SMR.getAll(modelId), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create()
        {
            ViewBag.Brands = BR.getAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubModel model)
        {
            if (ModelState.IsValid)
                SMR.Save(model);
            return RedirectToAction("/");
        }
        //public ActionResult Edit(int id)
        //{
        //    return View(SMR.get(id));
        //}

        //public ActionResult Delete(int id)
        //{
        //    return View(BR.get(id));
        //}
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteBrand(int id)
        {
            if (ModelState.IsValid)
                SMR.Delete(SMR.get(id));
            return RedirectToAction("/");
        }
        
        public ActionResult Edit (int id)
        {
            ViewBag.Brands = new SelectList(BR.getAll(), "Id", "Name", SMR.get(id).Model.brandId);
            ViewBag.Models = new SelectList(MR.getAll(),"Id","Name",SMR.get(id).modelId);
            return View(SMR.get(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SubModel model)
        {
            if (ModelState.IsValid)
                SMR.Update(model);
            return RedirectToAction("/");
        }
        public ActionResult Delete (int id)
        {
            return View(SMR.get(id));
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Deletex(int id)
        {
            if (ModelState.IsValid)
                SMR.Delete(SMR.get(id));
            return RedirectToAction("/");
        }

    }
}
