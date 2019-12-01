using Ecommerce.Areas.Management.Models.Context;
using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Repository
{
    public class SubModelRepository: IRepository <SubModel>
    {
        private ApplicationDbContext db;
        public SubModelRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Delete(SubModel entity)
        {
            db.SubModel.Remove(entity);
            db.SaveChanges();
        }

        public SubModel get(int Id)
        {
            return db.SubModel.FirstOrDefault(x => x.Id == Id);
        }

        public List<SubModel> getAll()
        {
            return db.SubModel.ToList();
        }

        public List<SubModel> getAll(int modelId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.SubModel.Where(x=>x.modelId==modelId).ToList();
        }


        public void Save(SubModel entity)
        {
            db.SubModel.Add(entity);
            db.SaveChanges();
        }

        public void Update(SubModel entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}