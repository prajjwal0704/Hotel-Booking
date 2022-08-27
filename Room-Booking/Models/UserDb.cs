using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Room_Booking.Models
{
    public class UserDb
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter the Name")]
        [DisplayName("Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter your Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please provide Username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Provide Id Proof")]
        public string IdProof { get; set; }

        [Required(ErrorMessage = "Please specify Gender.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter your Mobile Number")]
        public string MobileNo { get; set; }

        public bool isAdmin { get; set; } = false;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

    }
}
