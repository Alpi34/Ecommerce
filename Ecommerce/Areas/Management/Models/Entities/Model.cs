using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Entities
{
    public class Model: BaseEntitiy
    {
        //public int parentId { get; set; }
        public int brandId { get; set; }

        //one-one relation
        public virtual Brand brand { get; set; }
        public virtual ICollection<SubModel> SubModel { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}