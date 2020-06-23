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
        static private List<string> Events = new List<string>();
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
        public IActionResult AddEvent(string name)
        {
            Events.Add(name);

            return Redirect("/Events");
        }
    }
}
