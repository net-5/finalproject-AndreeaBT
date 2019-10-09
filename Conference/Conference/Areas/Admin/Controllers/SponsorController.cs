using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Data;
using Conference.Domain.Entities;
using Conference.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SponsorController : Controller
    {
        private readonly ISponsorService sponsorServices;
        public SponsorController(ISponsorService sponsorServices)
        {
            this.sponsorServices = sponsorServices;
        }
        [Area("Admin")]
        // GET: Edition
        public ActionResult Index()
        {
            IEnumerable<Sponsors> allSpeakers = sponsorServices.GetAllSponsors();
            return View(allSpeakers);
            //var allSponsors = sponsorServices.GetAllSponsors();
            //return View(allSponsors);
        }
        [Area("Admin")]
        // GET: Edition/Details/5
        public ActionResult Details(int id)
        {
            Sponsors sponsors = sponsorServices.GetSponsorById(id);
            SponsorViewModel model = new SponsorViewModel();
            model.InjectFrom(sponsors);
            return View(sponsors);
        }
        [Area("Admin")]
        // GET: Edition/Create
        public ActionResult Create()
        {
            //var sponsor = sponsorServices.GetAllSponsors();
            //ViewBag.Sponsors = sponsor;
            return View();
        }
        [Area("Admin")]
        // POST: Edition/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorViewModel model)
        {
            if (ModelState.IsValid)
            {
                Sponsors sponsors = new Sponsors();

                sponsors.InjectFrom(model);

                var createNewSponsor = sponsorServices.CreateSponsor(sponsors);

                if (createNewSponsor == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique!");

                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }
        [Area("Admin")]
        // GET: Edition/Edit/5
        public ActionResult Edit(int id)
        {
            var sponsor = sponsorServices.GetSponsorById(id);
            SponsorViewModel model = new SponsorViewModel();
            model.InjectFrom(sponsor);
            return View(model);
        }
        [Area("Admin")]
        // POST: Edition/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SponsorViewModel model)
        {
            Sponsors sponsors = new Sponsors();
            sponsors.InjectFrom(model);
            var sponsorToUpdate = sponsorServices.UpdateSponsor(sponsors);
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
        public ActionResult Delete(int id, SponsorViewModel model)
        {
            Sponsors sponsorToDelete = new Sponsors();
            sponsorToDelete = sponsorServices.GetSponsorById(id);
            model.InjectFrom(sponsorToDelete);
            sponsorServices.DeleteSponsor(sponsorToDelete);
            sponsorServices.Save();
            return RedirectToAction(nameof(Index));

        }
    }
}