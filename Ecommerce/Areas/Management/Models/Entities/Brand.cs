﻿using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Entities
{
    public class Brand : BaseEntitiy
    {
        //one to many relation
        public virtual ICollection<Model>  Model { get; set; }
        public virtual ICollection<Product> Product { get; set; }

    }
}