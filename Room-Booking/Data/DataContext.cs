using Microsoft.EntityFrameworkCore;
using Room_Booking.Models;

namespace Room_Booking.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<UserDb> User {get; set;}
        public DbSet<Rooms> Room { get; set; }
        public DbSet<Bookings> Booking { get; set; }
    }


}
