using Microsoft.AspNetCore.Mvc;//3. işlem-Controller sınıfının namespace'i

namespace MeetingApp.Controllers//1. işlem-MeetingApp projesi altında controller namespace'i tanımlıyoruz   
{

    public class MeetingController : Controller//2. işlem-MeetingApp projesi altında controller namespace'nin içinde MeetingController class'ı tanımlanıyor
    {

        public IActionResult Index()
        {
            return View();//4. işlem-MeetingController class’ın action metodu oluyor    
        }

        public IActionResult Apply()

        {

            return View();

        }

             public IActionResult List()

        {

            return View();

        }


    }
}