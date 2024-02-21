using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {

        // localhosts
        // localhost/home
        // localhost/home/index

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            // var selamlama = saat > 12 ? "İyi Günler":"Günaydın";

            ViewData["Selamlama"] = saat > 12 ? "İyi Günler":"Günaydın";
            int UserCount = Repository.Users.Where(info=> info.WillAttend == true).Count();

            // ViewData["Username"] = "Fatih";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul, Haliç Kongre Merkezi",
                Date = new DateTime(2024, 02, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo);
        }
    }

}