using System.Collections.Generic;
using MvcApp.Models;

namespace MvcApp.Core.Dal.Entities
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }      
    }
}