using Ecommerce.Areas.Management.Models.Context;
using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        private ApplicationDbContext db;
        public CategoryRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Delete(Category entity)
        {
            db.Category.Remove(entity);
            db.SaveChanges();
        }

        public Category get(int Id)
        {
           return db.Category.FirstOrDefault(x=>x.Id==Id);
        }

        public List<Category> getAll()
        {
            return db.Category.ToList();
        }

        public void Save(Category entity)
        {
            db.Category.Add(entity);
            db.SaveChanges();
        }

        public void Update(Category entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}