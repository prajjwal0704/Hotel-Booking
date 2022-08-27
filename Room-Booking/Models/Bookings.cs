using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Room_Booking.Models;

namespace Room_Booking.Models
{
    public class Bookings
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Rooms")]
        public int RoomsId { get; set; }

        public Rooms Room { get; set; }

        [ForeignKey("UserDb")]
        public int UserDbId { get; set; }
        public UserDb User { get; set; }
    }
}
