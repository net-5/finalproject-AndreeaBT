using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Models;
using Conference.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Controllers
{
    public class SpeakersController : Controller
    {
        private readonly ISpeakerService speakerService;
        public SpeakersController(ISpeakerService speakerService)
        {
            this.speakerService = speakerService;
        }

       
        // GET: Speakers
        public ActionResult Index()
        {
            IEnumerable<Speakers> allSpeakers = speakerService.GetSpeakers();
            return View(allSpeakers);
            //var allSpeakers = speakerService.GetSpeakers();
            //return View(allSpeakers);
        }

        
        // GET: Speakers/Details/5
        public ActionResult Details(int id)
        {
            Speakers speakers = speakerService.GetSpeakerById(id);
            SpeakerViewModel model = new SpeakerViewModel();
            model.InjectFrom(speakers);
            return View(speakers);

        }

        
    }
}