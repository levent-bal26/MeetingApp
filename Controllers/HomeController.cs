using Microsoft.AspNetCore.Mvc; //3. işlem-Controller sınıfının namespace'i


namespace MeetingApp.Controllers //1. işlem-MeetingApp projesi altında controller namespace'i tanımlıyoruz    

{
        public class HomeController : Controller //2. işlem-MeetingApp projesi altında controller namespace'nin içinde HomeController class'ı tanımlanıyor

    {

        //localhost
        //localhost/home
        //localhost/home/index

        public IActionResult Index()

        {
            return View(); //4. işlem-HomeController class’ın action metodu oluyor       
        }

    }
}