using Ecommerce.Areas.Management.Models.Context;
using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Repository
{
    public class BrandRepository : IRepository<Brand>

         
    {
        private ApplicationDbContext db;
        public BrandRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Delete(Brand entity)
        {
            db.Brand.Remove(entity);
            db.SaveChanges();
        }

        public Brand get(int Id)
        {
            return db.Brand.FirstOrDefault(x => x.Id == Id);
        }

        public List<Brand> getAll()
        {
            return db.Brand.ToList();
        }

        public void Save(Brand entity)
        {
            db.Brand.Add(entity);
            db.SaveChanges();
        }

        public void Update(Brand entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}