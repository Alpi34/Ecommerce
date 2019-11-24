using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Ecommerce.Areas.Management.Models.Entities
{
    public enum autoClass
    {
        Ekonomik,
        OrtaSınıf,
        LüxSınıf
    }

    public enum autoFuelType
    {
        Benzin,
        Dizel,
        Elektrik,
        BenzinElektrik,
        Gaz
    }

    public enum autoGearType
    {
        Manuel,
        Otomatik
    }
   
    public class Product: BaseEntitiy
    {
        [Display(Name="Araç Sınıfı")]
        [Required(ErrorMessage ="Araç Sınıf Tipini Seçiniz")]
        public autoClass ClassType { get; set; }

        [Display(Name = "Yakıt Tipi")]
        [Required(ErrorMessage = "Araç Yakıt Tipini Seçiniz")]
        public autoFuelType FuelType { get; set; }

        [Display(Name = "Vites Tipi")]
        [Required(ErrorMessage = "Araç Vites Tipini Seçiniz")]
        public autoGearType GearType { get; set; }

        [Display(Name = "Tutar")]
        [Required(ErrorMessage = "Araç Günlük Ücretini Girmediniz")]
        public decimal dailyPrice { get; set; }
        [Display(Name ="İndirim")]
        public decimal discount { get; set; }

        [Display(Name ="Model Yılı")]
        public int autoModelYear { get; set; }
        [Display(Name ="Kilometre")]
        public int km { get; set; }
        public byte[] image { get; set; }

        public int brandId { get; set; }
        public int categoryId { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}