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

            int saat = DateTime.Now.Hour;//Dinamik veri eklemek için yapılıyor                           

            //ViewBag.Selamlama= saat > 12 ? "İyi günler":"Günaydın"; //Dinamik veri eklemek için yapılıyor.Home/Index.cshtml dosyasına gönderme yapıyor

            ViewData["Selamlama"]= saat > 12 ? "İyi günler":"Günaydın";
            ViewData["UserName"]= "Çınar";


            return View(); //4. işlem-HomeController class’ın action metodu oluyor. Views\Home\Index.cshtml'e gönderme yapıyor.       
        }

    }
}