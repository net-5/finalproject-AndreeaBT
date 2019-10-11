using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conference.Controllers
{
    public class ConditionsController : Controller
    {
        // GET: Conditions
        public ActionResult Index()
        {
            return View();
        }

       
    }
}