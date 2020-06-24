using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;
using CodingEvents.Data;

namespace CodingEvents.Controllers
{
    [Route("Events")]
    public class EventsController : Controller
    {
        //static private List<Event> Events = new List<Event>();
        //GET: events
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpGet("Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("Add")]
        public IActionResult AddEvent(Event newEvent)
        {
            //Events.Add(name, date.Date.ToString("d"));
            EventData.Add(newEvent);

            return Redirect("/Events");
        }
        [HttpGet("Delete")]
        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost("Delete")]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }

        [HttpGet("Edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            // controller code will go here
            ViewBag.eventToEdit = EventData.GetById(eventId);
            ViewBag.title = $"Edit Event {EventData.GetById(eventId).Name}(id = {eventId})";
            return View();
        }

        [HttpPost("Edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        {
            // controller code will go here
            EventData.GetById(eventId).Name = name;
            EventData.GetById(eventId).Description = description;

            return Redirect("/Events");
        }
    }
}
