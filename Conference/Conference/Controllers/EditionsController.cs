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
    public class EditionsController : Controller
    {
        private readonly IEditionsServices editionServices;
        public EditionsController(IEditionsServices editionServices)
        {
            this.editionServices = editionServices;
        }
        // GET: Editions
        public ActionResult Index()
        {
            IEnumerable<Editions> allEditions = editionServices.GetEditions();
            return View(allEditions);
        }

        // GET: Editions/Details/5
        public ActionResult Details(int id)
        {
            Editions editions = editionServices.GetById(id);
            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(editions);
            return View(editions);
        }

        
    }
}