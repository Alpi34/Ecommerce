using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Management.Models.Interface
{
    interface IRepository <T> where T: BaseEntitiy
    {
        void Save(T entity);
        void Update(T entity);
        void Delete(T entity);
        T get(int Id);
        List<T> getAll();
    }

}
