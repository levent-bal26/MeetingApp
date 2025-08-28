using Microsoft.AspNetCore.Mvc;//3. işlem-Controller sınıfının namespace'i

using MeetingApp.Models;

namespace MeetingApp.Controllers//1. işlem-MeetingApp projesi altında controller namespace'i tanımlıyoruz   
{

    public class MeetingController : Controller//2. işlem-MeetingApp projesi altında controller namespace'nin içinde MeetingController class'ı tanımlanıyor
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();//4. işlem-MeetingController class’ın action metodu oluyor. Views\Meeting\Index.cshtml'e gönderme yapıyor.    
        }
        [HttpGet]
        public IActionResult Apply()

        {

            return View();//4. işlem-MeetingController class’ın action metodu oluyor. Views\Meeting\Apply.cshtml'e gönderme yapıyor.

        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)

        {

            return View();//4. işlem-MeetingController class’ın action metodu oluyor. Views\Meeting\Apply.cshtml'e gönderme yapıyor.

        }

        [HttpGet]
        public IActionResult List()

        {

            return View();//4. işlem-MeetingController class’ın action metodu oluyor. Views\Meeting\List.cshtml'e gönderme yapıyor.

        }


    }
}