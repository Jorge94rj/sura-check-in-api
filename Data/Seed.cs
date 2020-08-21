using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SuraCheckIn.API.Models;

namespace SuraCheckIn.API.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext context)
        {
            if(!context.Events.Any())
            {
                var eventsData = System.IO.File.ReadAllText("Data/EventSeedData.json");
                var events = JsonConvert.DeserializeObject<List<Event>>(eventsData);
                foreach(var eventObj in events) 
                {
                    context.Events.Add(eventObj);
                }
                context.SaveChanges();
            }
        }
    }
}