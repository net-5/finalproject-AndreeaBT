using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EditionsController : Controller
    {
        private readonly IEditionsServices editionServices;
        public EditionsController(IEditionsServices editionServices)
        {
            this.editionServices = editionServices;
        }
        [Area("Admin")]
        // GET: Edition
        public ActionResult Index()
        {
            IEnumerable<Editions> allEditions = editionServices.GetEditions();
            return View(allEditions);
            //var allEditions = editionServices.GetEditions();
            //return View(allEditions);
        }
        [Area("Admin")]
        // GET: Edition/Details/5
        public ActionResult Details(int id)
        {
            Editions editions = editionServices.GetById(id);
            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(editions);
            return View(editions);
        }
        [Area("Admin")]
        // GET: Edition/Create
        public ActionResult Create()
        {
            return View();
        }
        [Area("Admin")]
        // POST: Edition/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditionViewModel model)
        {
            if (ModelState.IsValid)
            {
                Editions edition = new Editions();

                edition.InjectFrom(model);

                var createNewEdition = editionServices.AddEditions(edition);

                if (createNewEdition == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique!");

                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
            
        }
        [Area("Admin")]
        // GET: Edition/Edit/5
        public ActionResult Edit(int id)
        {
            //var speaker = editionServices.GetById(id);

            //return View(speaker);
            var edition = editionServices.GetById(id);
            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(edition);
            return View(model);
        }
        [Area("Admin")]
        // POST: Edition/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditionViewModel model)
        {
           
            Editions edition = new Editions();
            edition.InjectFrom(model);
            var editionToUpdate = editionServices.Update(edition);
            return RedirectToAction(nameof(Index));
        }
        [Area("Admin")]
        
        public ActionResult Delete(int id)
        {
            //var editionToDelete = editionServices.GetById(id);
            //Editions model = new Editions();
            //model.InjectFrom(editionToDelete);
            return View();
        }
        [Area("Admin")]
        // POST: Edition/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EditionViewModel model)
        {
            
            Editions editiontodelete = new Editions();
            editiontodelete = editionServices.GetById(id);
            model.InjectFrom(editiontodelete);
            editionServices.DeleteEdition(editiontodelete);
            editionServices.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}