using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models; // MeetingInfo class'ı burada

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        // localhost
        // localhost/home
        // localhost/home/index
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            // ViewBag yerine ViewData ile dinamik veri gönderiyoruz
            ViewData["Selamlama"] = saat > 12 ? "İyi günler" : "Günaydın";
            ViewData["UserName"] = "Çınar";

            var MeetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = 100
            };

            // 🔥 Burada modeli View'e gönderiyoruz
            return View(MeetingInfo);
        }
    }
}
