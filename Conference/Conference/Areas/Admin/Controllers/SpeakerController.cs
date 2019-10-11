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
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpeakersController : Controller
    {
        private readonly ISpeakerService speakerService;
        public SpeakersController(ISpeakerService speakerService)
        {
            this.speakerService = speakerService;
        }

        [Area("Admin")]
        // GET: Speakers
        public ActionResult Index()
        {
            IEnumerable<Speakers> allSpeakers = speakerService.GetSpeakers();
            return View(allSpeakers);
            //var allSpeakers = speakerService.GetSpeakers();
            //return View(allSpeakers);
        }

        [Area("Admin")]
        // GET: Speakers/Details/5
        public ActionResult Details(int id)
        {
            Speakers speakers = speakerService.GetSpeakerById(id);
            SpeakersViewModel model = new SpeakersViewModel();
            model.InjectFrom(speakers);
            return View(speakers);
            
        }

        [Area("Admin")]
        // GET: Speakers/Create
        public ActionResult Create()
        {
            //var allSpeakers = speakerService.GetSpeakers();
            //ViewBag.Speakers = allSpeakers;
            return View();
        }

        [Area("Admin")]
        // POST: Speakers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpeakersViewModel model)
        {
            if (ModelState.IsValid)
            {
                Speakers speakers = new Speakers();

                speakers.InjectFrom(model);

                var createNewSpeaker = speakerService.AddSpeaker(speakers);

                if (createNewSpeaker == null)
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
        // GET: Speakers/Edit/5
        public ActionResult Edit(int id)
        {
            var speaker = speakerService.GetSpeakerById(id);
            SpeakersViewModel model = new SpeakersViewModel();
            model.InjectFrom(speaker);
            return View(model);
            
        }

        [Area("Admin")]
        // POST: Speakers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SpeakersViewModel model)
        {
            Speakers speakers = new Speakers();
            speakers.InjectFrom(model);
            var speakerToUpdate = speakerService.UpdateSpeaker(speakers);
            return RedirectToAction(nameof(Index));
            
        }

        [Area("Admin")]
        // GET: Speakers/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View();
        }
        

        [Area("Admin")]
        // POST: Speakers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SpeakersViewModel model)
        {
            Speakers speakerToDelete = new Speakers();
            speakerToDelete = speakerService.GetSpeakerById(id);
            model.InjectFrom(speakerToDelete);
            speakerService.DeleteSpeaker(speakerToDelete);
            speakerService.Save();
            return RedirectToAction(nameof(Index));
           
        }
    }
}