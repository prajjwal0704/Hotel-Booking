using Microsoft.AspNetCore.Mvc;
using Room_Booking.Data;
using Room_Booking.Models;
using Room_Booking.ViewModels;
using System.Text;

namespace Room_Booking.Controllers
{
    public class AuthController : Controller
    {
        private readonly DataContext _db;

        public AuthController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult<UserDb> Index([FromForm]LoginViewModel form)
        {
            var user = _db.User.FirstOrDefault(x => x.Email == form.Email);
            if (user != null)
            {
                if(user.Password == encryptpass(form.Password))
                {
                    return View("DashboardClientLogin", user);
                }
                return View(form);
            }
            return RedirectToAction("Index");
        }

        public ActionResult DashboardClientLogin(UserDb user)
        {
            return View(user);
        }

        

        public IActionResult SignUp()
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp([FromForm]UserDb form)
        {
            if(ModelState != null)
            {
                var password = encryptpass(form.Password);
                form.Password = password;
                await _db.User.AddAsync(form);
                await _db.SaveChangesAsync();
                TempData["success"] = "Account is Created.";
                return RedirectToAction("Index");
            }
            return View();
        }
        public string encryptpass(string password)
        {
            string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.ToBase64String(encode);
            return msg;
        }

        
    }
}
