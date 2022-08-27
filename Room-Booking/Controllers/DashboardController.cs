using Microsoft.AspNetCore.Mvc;
using Room_Booking.Data;
using Room_Booking.Models;

namespace Room_Booking.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DataContext _db;
        public DashboardController(DataContext db)
        {
            _db = db;
        }

        public async Task<ActionResult<UserDb>> Index(UserDb user)
        {
            //var request = Request.QueryString;
            //var loggedUser = await _db.User.FindAsync(user);
            return View(user);
        }
    }
}
