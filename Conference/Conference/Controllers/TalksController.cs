using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Domain.Entities;
using Conference.Models;
using Conference.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Controllers
{
    public class TalksController : Controller
    {
        private readonly ITalkService talkService;
        public TalksController(ITalkService talkService)
        {
            this.talkService = talkService;
        }

        // GET: Talks
        public ActionResult Index()
        {
            IEnumerable<Talks> allTalks = talkService.GetAllTalks();
            return View(allTalks);
        }

        // GET: Talks/Details/5
        public ActionResult Details(int id)
        {
            Talks talks = talkService.GetTalkById(id);
            TalksViewModel model = new TalksViewModel();
            model.InjectFrom(talks);
            return View(talks);
        }
    }
}