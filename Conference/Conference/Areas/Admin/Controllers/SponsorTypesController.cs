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
    public class SponsorTypesController : Controller
    {
        private readonly ISponsorTypesService sponsorTypesServices;
        public SponsorTypesController(ISponsorTypesService sponsorTypesServices)
        {
            this.sponsorTypesServices = sponsorTypesServices;
        }
        [Area("Admin")]
        // GET: Edition
        public ActionResult Index()
        {
            IEnumerable<SponsorTypes> allSponsorTypes = sponsorTypesServices.GetAllSponsorTypes();
            return View(allSponsorTypes);
        }
        [Area("Admin")]
        // GET: Edition/Details/5
        public ActionResult Details(int id)
        {
            SponsorTypes sponsors = sponsorTypesServices.GetSponsorTypeById(id);
            SponsorTypesViewModel model = new SponsorTypesViewModel();
            model.InjectFrom(sponsors);
            return View(sponsors);
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
        public ActionResult Create(SponsorTypesViewModel sponsorTypes)
        {
            if (ModelState.IsValid)
            {
                SponsorTypes sponsors = new SponsorTypes();

                sponsors.InjectFrom(sponsorTypes);

                var createNewSponsor = sponsorTypesServices.CreateSponsorType(sponsors);

                if (createNewSponsor == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique!");

                    return View(sponsorTypes);
                }
            }
            return RedirectToAction(nameof(Index));
        }
        [Area("Admin")]
        // GET: Edition/Edit/5
        public ActionResult Edit(int id)
        {
            var sponsor = sponsorTypesServices.GetSponsorTypeById(id);
            SponsorTypesViewModel model = new SponsorTypesViewModel();
            model.InjectFrom(sponsor);
            return View(model);
        }
        [Area("Admin")]
        // POST: Edition/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SponsorTypesViewModel model)
        {
            SponsorTypes sponsors = new SponsorTypes();
            sponsors.InjectFrom(model);
            var sponsorToUpdate = sponsorTypesServices.UpdateSponsorType(sponsors);
            return RedirectToAction(nameof(Index));
        }
        [Area("Admin")]
        // GET: Edition/Delete/5
        public ActionResult Delete(int id)
        {
           
            return View();
        }
        [Area("Admin")]
        // POST: Edition/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorTypesViewModel model)
        {
            SponsorTypes sponsorTypeToDelete = new SponsorTypes();
            sponsorTypeToDelete = sponsorTypesServices.GetSponsorTypeById(id);
            model.InjectFrom(sponsorTypeToDelete);
            sponsorTypesServices.DeleteSponsorType(sponsorTypeToDelete);
            sponsorTypesServices.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}