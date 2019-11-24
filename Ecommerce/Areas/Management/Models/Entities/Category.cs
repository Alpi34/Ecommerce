using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Entities
{
    public class Category:BaseEntitiy
    {
        public int parentID { get; set; }
        public string Description{ get; set; }
    }
}