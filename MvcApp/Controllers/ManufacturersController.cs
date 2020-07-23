using MvcApp.Models;
using System.Web.Mvc;
using MvcApp.Core.Dal.Repositories;
using MvcApp.Core.Dal.Entities;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;

namespace MvcApp.Controllers
{
    public class ManufacturersController : Controller
    {
        ManufacturerRepository repository = new ManufacturerRepository();
        private ManufacturerDetailModel Model = new ManufacturerDetailModel();
        
        // GET: Manufacturer
        public ActionResult Index()
        {
            var model = new ManufacturerGridModel
            {
                Items = repository.GetManufacturers()
            };      
            return View(model);
        }

        // GET: Manufacturer/Details/5
        public ActionResult Details(int Id)
        {
            repository.Details(Id);
            return View(Model);
        }

        // GET: Manufacturer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manufacturer/Create
        [HttpPost]
        public ActionResult Create(ManufacturerDetailModel Model)
        {            
            if (ModelState.IsValid)
            {
                repository.Create(
                new Manufacturer
                {
                    Id = Model.Id,
                    Name = Model.Name,
                    Description = Model.Description
                });
                ViewBag.Message = "Запись успешно добавлена";
            }
            //return View(Model);
            return RedirectToAction("Index");
        }

        // GET: Manufacturer/Edit/5
        public ActionResult Edit()
        {           
            return View(Model);
        }

        // POST: Manufacturer/Edit/5
        [HttpPost]
        public ActionResult Edit(ManufacturerDetailModel Model)
        {            
            repository.Edit(
                new Manufacturer
                {
                    Id = Model.Id,
                    Name = Model.Name,
                    Description = Model.Description
                });
             return RedirectToAction("Index");
        }

        // GET: Manufacturer/Delete/5
        public ActionResult Delete()
        {
            ManufacturerDetailModel Model = new ManufacturerDetailModel();            
            return View(Model);
        }

        // POST: Manufacturer/Delete/5
        [HttpPost]
        public ActionResult Delete(ManufacturerDetailModel model)
        {
            repository.Delete(model.Id);
            ViewBag.Message = "Запись успешно удалена";
            return RedirectToAction("Index");
        }
    }
}
