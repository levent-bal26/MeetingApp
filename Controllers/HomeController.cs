using Microsoft.AspNetCore.Mvc; //public class HomeController: Controller classının name spacesi


namespace MeetingApp.Controllers //HomeController dosyasını MeetingApp projesine bağlamak için yazılıyor

{
        public class HomeController : Controller //MeetingApp projesinin altında bu dosya bir class olarak tanımlanmış oluyor 

    {

        //localhost
        //localhost/home
        //localhost/home/index

        public string Index()

        {
            return "home/index"; //içinde bulunduğu class’ın action metodu oluyor       
        }

    }
}