using System.Collections.Generic;
using SuraCheckIn.API.Models;

namespace SuraCheckIn.API.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public byte [] PasswordHash { get; set; }
        public byte [] PasswordSalt { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Charge { get; set; }
        public ICollection<UserEvent> UserEvents { get; set; }
    }
}