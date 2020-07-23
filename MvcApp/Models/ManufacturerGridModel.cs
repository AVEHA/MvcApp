using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcApp.Core.Dal.Entities;

namespace MvcApp.Models
{
    public class ManufacturerGridModel 
    {
        public List<Manufacturer> Items { get; set; }
    }
}