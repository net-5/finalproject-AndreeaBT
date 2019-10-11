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
    public class WorkshopsController : Controller
    {
        private readonly IWorkshopService workshopService;
        public WorkshopsController(IWorkshopService workshopService)
        {
            this.workshopService = workshopService;
        }

       
        // GET: Workshops
        public ActionResult Index()
        {
            IEnumerable<Workshops> allWorkshops = workshopService.GetAllWorkshops();
            return View(allWorkshops);
        }

       
        // GET: Workshops/Details/5
        public ActionResult Details(int id)
        {
            Workshops workshops = workshopService.GetWorkshopById(id);
            WorkshopViewModel model = new WorkshopViewModel();
            model.InjectFrom(workshops);
            return View(workshops);
        }
    }
}