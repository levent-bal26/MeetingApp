var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //projeye mvc şablonunu dahil etmek için bu ifade yazılıyor

var app = builder.Build();

app.UseStaticFiles();//wwwroot altındaki static dosyalara bu sayede erişim sağlanmış olacak

app.UseRouting(); //Routing yönlendirmesi için medial veri aktif edilmiş oluyor

app.MapControllerRoute(

name: "Default",

pattern: "{controller=Home}/{action=Index}/{id?}" //(action metodu bu şekilde çağrılıyor) BAŞKA BİR YÖNTEM



);

app.Run();

/* ASP.NET Core 9.0’da Program.cs dosyası olmazsa proje teknik olarak çalışmaz çünkü bu dosya uygulamanın başlangıç noktasıdır — yani entry point.

Bu dosya şu işe yarar:

Main metodu içerir
.NET Core uygulamaları, tıpkı diğer C# programları gibi Main metodundan başlar.
ASP.NET Core’da Program.cs içinde Main metodu WebApplication’ı oluşturur ve çalıştırır.

Host’u (sunucu ortamını) başlatır

Kestrel web sunucusunu ayağa kaldırır.

HTTP pipeline’ı, middleware’leri ve servisleri yükler.

Uygulamanın konfigürasyonunu yapar

appsettings.json, environment değişkenleri gibi yapılandırmalar buradan yüklenir.

Dependency Injection (DI) container’ı burada hazırlanır.

Middleware’leri tanımlar

Routing, authentication, logging, CORS, Swagger vb. burada eklenir.

Sonuç:

Program.cs dosyası zorunludur, çünkü uygulama buradan başlar.

İstersen ismini değiştirebilirsin ama içinde Main metodunu barındıran bir dosya mutlaka olmalı.

.NET 6’dan sonra Startup.cs çoğunlukla kaldırıldı, ayarlar direkt Program.cs içine yazılıyor. */