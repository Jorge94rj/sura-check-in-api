using Microsoft.EntityFrameworkCore;
using SuraCheckIn.API.Models;

namespace SuraCheckIn.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) {}
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
    }
}