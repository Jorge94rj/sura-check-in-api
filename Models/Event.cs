using System.Collections.Generic;
using SuraCheckIn.API.Data;

namespace SuraCheckIn.API.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public virtual ICollection<UserEvent> UserEvents { get; set; }
    }
}