using System.Collections.Generic;
using SuraCheckIn.API.Models;

namespace SuraCheckIn.API.Dtos
{
    public class UserListDto
    {
        public string Email { get; set; }
        public List<Event> Events { get; set; }
    }
}