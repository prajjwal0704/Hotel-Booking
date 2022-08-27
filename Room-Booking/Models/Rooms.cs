using System.ComponentModel.DataAnnotations;

namespace Room_Booking.Models
{
    public class Rooms
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Fare { get; set; }

        [Required]
        public int TotalCapacity { get; set; }

        [Required]
        public int RemainingCapacity { get; set; }

    }
}
