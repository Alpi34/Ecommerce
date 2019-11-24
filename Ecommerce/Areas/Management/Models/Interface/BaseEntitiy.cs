using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Areas.Management.Models.Interface
{
    public abstract class BaseEntitiy
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Ad")]
        [Required(ErrorMessage ="Bir Ad Belirtmeniz Gerekir")]
        public string Name { get; set; }
        [Display(Name = "Urun Oluşturma Tarihi")]
        public DateTime created => DateTime.Now;
    }
}