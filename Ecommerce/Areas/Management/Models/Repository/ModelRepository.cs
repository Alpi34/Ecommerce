using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Interface;
using Ecommerce.Areas.Management.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Repository
{
    public class ModelRepository: IRepository<Model>
    {
        private ApplicationDbContext db;
        public ModelRepository (ApplicationDbContext _db)
        {
            db = _db;
        }

        public void Delete(Model entity)
        {
            db.Model.Remove(entity);
            db.SaveChanges();
        }

        public Model get(int Id)
        {
            return db.Model.FirstOrDefault(x => x.Id == Id);
        }

        public List<Model> getAll()
        {
            return db.Model.ToList();
        }

        public List<Model> GetAll(int brandId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Model.Where(x => x.brandId == brandId).ToList();
        }

        public void Save(Model entity)
        {
            db.Model.Add(entity);
            db.SaveChanges();
        }

        public void Update(Model entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}