﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CodingEvents.Models;

namespace CodingEvents.Data
{
    public class EventData
    {
        // store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        // add events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        // retrieve events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        // retrieve single event
        public static Event GetById(int Id)
        {
            return Events[Id];
        }

        // remove an event
        public static void Remove(int Id)
        {
            Events.Remove(Id);
        }
    }
}
