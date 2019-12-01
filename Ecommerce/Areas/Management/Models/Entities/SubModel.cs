using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ecommerce.Areas.Management.Models.Interface;

namespace Ecommerce.Areas.Management.Models.Entities
{
    public class SubModel: BaseEntitiy
    {
        public int modelId { get; set; }

        public virtual Model Model { get; set; }
        public virtual ICollection<Product> Product { get; set; }


    }

}