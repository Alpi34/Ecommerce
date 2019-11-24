using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Areas.Management.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository CR = new CategoryRepository(new Models.Context.ApplicationDbContext());
        // GET: Management/Category
        public ActionResult Index()
        {
            return View(CR.getAll());
        }
        public ActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (Category model)
        {
            if (ModelState.IsValid)
                CR.Save(model);
            return RedirectToAction("/");
        }
        public ActionResult Edit (int id)
        {
            return View(CR.get(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if(ModelState.IsValid)
            CR.Update(model);
            return RedirectToAction("/");
        }

        public ActionResult Delete (int id)
        {
            return View(CR.get(id));
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCategory(int id)
        {
            if (ModelState.IsValid)
                CR.Delete(CR.get(id));
            return RedirectToAction("/");
        }
    }
}