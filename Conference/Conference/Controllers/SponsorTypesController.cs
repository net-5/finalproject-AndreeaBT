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
    public class SponsorTypesController : Controller
    {
        private readonly ISponsorTypesService sponsorTypesServices;
        public SponsorTypesController(ISponsorTypesService sponsorTypesServices)
        {
            this.sponsorTypesServices = sponsorTypesServices;
        }
        // GET: Edition
        public ActionResult Index()
        {
            IEnumerable<SponsorTypes> allSponsorTypes = sponsorTypesServices.GetAllSponsorTypes();
            return View(allSponsorTypes);
        }
        // GET: Edition/Details/5
        public ActionResult Details(int id)
        {
            SponsorTypes sponsors = sponsorTypesServices.GetSponsorTypeById(id);
            SponsorTypeViewModel model = new SponsorTypeViewModel();
            model.InjectFrom(sponsors);
            return View(sponsors);
        }
    }
}