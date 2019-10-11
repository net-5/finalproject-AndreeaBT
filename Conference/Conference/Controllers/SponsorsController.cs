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
    public class SponsorsController : Controller
    {
        private readonly ISponsorService sponsorServices;
        public SponsorsController(ISponsorService sponsorServices)
        {
            this.sponsorServices = sponsorServices;
        }
        // GET: Edition
        public ActionResult Index()
        {
            IEnumerable<Sponsors> allSpeakers = sponsorServices.GetAllSponsors();
            return View(allSpeakers);
            //var allSponsors = sponsorServices.GetAllSponsors();
            //return View(allSponsors);
        }
        // GET: Edition/Details/5
        public ActionResult Details(int id)
        {
            Sponsors sponsors = sponsorServices.GetSponsorById(id);
            SponsorViewModel model = new SponsorViewModel();
            model.InjectFrom(sponsors);
            return View(sponsors);
        }

        
    }
}