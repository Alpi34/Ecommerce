using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Areas.Management.Controllers
{
    public class ProductController : Controller
    {
        // GET: Management/Product
        ProductRepository PR = new ProductRepository(new Models.Context.ApplicationDbContext());
        BrandRepository BR = new BrandRepository(new Models.Context.ApplicationDbContext());
        CategoryRepository CR = new CategoryRepository(new Models.Context.ApplicationDbContext());
        public ActionResult Index()
        {
            return View(PR.getAll());
        }
        public ActionResult Create ()
        {
            var year = new List<string>();
            for(int i = 2015; i <=2020; i++)
            {
                year.Add(i.ToString());
            }
            ViewBag.ModelYear = new SelectList(year);
            ViewBag.Brands = BR.getAll();
            ViewBag.Categories = CR.getAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (Product Model,HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    using (var br = new BinaryReader(image.InputStream))
                    {
                        var data = br.ReadBytes(image.ContentLength);
                        Model.image = data;
                    }
                }
                PR.Save(Model);

                return RedirectToAction("/");

            }
            var year = new List<string>();
            for (int i = 2015; i <= 2020; i++)
            {
                year.Add(i.ToString());
            }
            ViewBag.ModelYear = new SelectList(year);
            ViewBag.Brands = BR.getAll();
            ViewBag.Categories = CR.getAll();
            ModelState.AddModelError("", "Model Yükleme Hatası !");
            return View();
            
        }
    }
}