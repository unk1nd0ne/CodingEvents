using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    [Route("Events")]
    public class EventsController : Controller
    {
        static private Dictionary<string, string> Events = new Dictionary<string, string>();
        //GET: events
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.events = Events;

            return View();
        }

        [HttpGet("Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("Add")]
        public IActionResult AddEvent(string name, string description)
        {
            //Events.Add(name, date.Date.ToString("d"));
            Events.Add(name, description);

            return Redirect("/Events");
        }
    }
}
