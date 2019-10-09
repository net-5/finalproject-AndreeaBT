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
    public class TalksController : Controller
    {
        private readonly ITalkService talkService;
        public TalksController(ITalkService talkService)
        {
            this.talkService = talkService;
        }

        [Area("Admin")]
        // GET: Talks
        public ActionResult Index()
        {
            IEnumerable<Talks> allTalks = talkService.GetAllTalks();
            return View(allTalks);
        }

        [Area("Admin")]
        // GET: Talks/Details/5
        public ActionResult Details(int id)
        {
            Talks talks = talkService.GetTalkById(id);
            TalksViewModel model = new TalksViewModel();
            model.InjectFrom(talks);
            return View(talks);
        }

        [Area("Admin")]
        // GET: Talks/Create
        public ActionResult Create()
        {
            //var talks = talkService.GetAllTalks();
            //ViewBag.Talks = talks;
            return View();
        }

        [Area("Admin")]
        // POST: Talks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TalksViewModel model)
        {
            if (ModelState.IsValid)
            {
                Talks talks = new Talks();

                talks.InjectFrom(model);

                var createNewTalk = talkService.AddTalk(talks);

                if (createNewTalk == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique!");

                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [Area("Admin")]
        // GET: Talks/Edit/5
        public ActionResult Edit(int id)
        {
            var talk = talkService.GetTalkById(id);
            TalksViewModel model = new TalksViewModel();
            model.InjectFrom(talk);
            return View(model);
        }

        [Area("Admin")]
        // POST: Talks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TalksViewModel model)
        {
            Talks talks = new Talks();
            talks.InjectFrom(model);
            var sponsorToUpdate = talkService.UpdateTalk(talks);
            return RedirectToAction(nameof(Index));
        }

        [Area("Admin")]
        // GET: Talks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        [Area("Admin")]
        // POST: Talks/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TalksViewModel model)
        {
            Talks talkToDelete = new Talks();
            talkToDelete = talkService.GetTalkById(id);
            model.InjectFrom(talkToDelete);
            talkService.Delete(talkToDelete);
            talkService.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}