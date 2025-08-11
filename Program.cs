var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //projeye mvc şablonunu dahil etmek için bu ifade yazılıyor

var app = builder.Build();

app.MapControllerRoute(

name: "Default",

pattern: "{controller=Home}/{action=Index}/{id?}" //(action metodu bu şekilde çağrılıyor) BAŞKA BİR YÖNTEM



);

app.Run();
