using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcApp.Core.Dal.Entities;

namespace MvcApp.Models
{
    public class ManufacturerDetailModel 
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Введите название производителя!")]
        //[RegularExpression(@"[A-Za-z0-9.]{2-50}$", ErrorMessage = "Некорректное имя производителя")]
        [Display(Name = "Производитель")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        public List<Manufacturer> Manufacturer_List { get; set; }
    }
}