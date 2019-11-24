using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using Ecommerce.Areas.Management.Models.Context;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private ApplicationDbContext db;
        public ProductRepository (ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Delete(Product entity)
        {
            db.Product.Remove(entity);
            db.SaveChanges();
        }

        public Product get(int Id)
        {
            return db.Product.FirstOrDefault(x => x.Id == Id);
        }

        public List<Product> getAll()
        {
            return db.Product.ToList();
        }

        public void Save(Product entity)
        {
            db.Product.Add(entity);
            db.SaveChanges();
        }

        public void Update(Product entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}