using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Entities
{
    public class Model: BaseEntitiy
    {
        public int parentId { get; set; }
        public int brandId { get; set; }

        public Brand brand { get; set; }
    }
}