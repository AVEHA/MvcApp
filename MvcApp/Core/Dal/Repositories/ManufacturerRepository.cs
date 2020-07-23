using System.Collections.Generic;
using System.Linq;
using MvcApp.Core.Dal.Entities;


namespace MvcApp.Core.Dal.Repositories
{
    public class ManufacturerRepository 
    {
        
        public static List<Manufacturer> manufacturerList = new List<Manufacturer>()
        {
            new Manufacturer { Id = 0, Name = "Name1", Description = "Description1"},
            new Manufacturer { Id = 1, Name = "Name2", Description = "Description2"},
            new Manufacturer { Id = 2, Name = "Name3", Description = "Description3"}
        };        
        
        public List<Manufacturer> GetManufacturers()
        {
            foreach (Manufacturer manufacturer in manufacturerList)
            {
                return manufacturerList;
            }
            return manufacturerList;
        }

        public List<Manufacturer> Create(Manufacturer manufacturer)
        {
            int last = manufacturerList.Count;
            manufacturerList.Add(new Manufacturer { Id = last, Name = manufacturer.Name, Description = manufacturer.Description});
            return manufacturerList;
        }

        public void Delete(int id)
        {
            Manufacturer manufacturerDelete = manufacturerList.Single(m => m.Id == id);
            manufacturerList.Remove(manufacturerDelete);
          
            //manufacturerList.RemoveAt(id);            
        }

        public void Edit(Manufacturer manufacturer)
        {   
            Manufacturer manufacturerUpdate = manufacturerList.Single(m => m.Id == manufacturer.Id);
            manufacturerUpdate.Name = manufacturer.Name;
            manufacturerUpdate.Description = manufacturer.Description;            
        }

        public Manufacturer Details(int id)
        {
            Manufacturer manufacturerDetails = GetManufacturers().Single(m => m.Id == id);
            return manufacturerDetails;
        }

        /*public Manufacturer Get(int id)
        {                     
            return manufacturerList.SingleOrDefault(s => s.Id == id);
        }*/
    }
}