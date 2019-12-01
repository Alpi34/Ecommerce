using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Ecommerce.Areas.Management.Controllers
{
    public class ModelController : Controller
        
    {
        ModelRepository MR = new ModelRepository(new Models.Context.ApplicationDbContext());
        BrandRepository BR = new BrandRepository(new Models.Context.ApplicationDbContext());
        public ActionResult Index()
        {
            return View (MR.getAll());
        }
        public ActionResult Create()
        {
            ViewBag.Brands = BR.getAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Model model)
        {
            if (ModelState.IsValid)
                MR.Save(model);
            return RedirectToAction("/");
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Brands = BR.getAll();
            return View(MR.get(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (Model model)
        {
            if (ModelState.IsValid)
                MR.Save(model);
            return RedirectToAction("/");
        }
        public ActionResult Delete(int id)
        {
            ViewBag.Brands = BR.getAll();
            return View(MR.get(id));
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteModel(int id)
        {
            if (ModelState.IsValid)
                MR.Delete(MR.get(id));
            return RedirectToAction("/");
        }
    }
}