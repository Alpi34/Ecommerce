﻿using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Areas.Management.Models.Entities
{
    public class Category:BaseEntitiy
    {
        [Display(Name ="Üst Kategori")]
        public int parentID { get; set; }
        [Display(Name = "Açıklama")]
        public string Description{ get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}