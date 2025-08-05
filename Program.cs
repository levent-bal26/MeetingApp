var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //projeye mvc şablonunu dahil etmek için bu ifade yazılıyor

var app = builder.Build();

app.MapDefaultControllerRoute();//{controller=Home}/{action=Index}/{id?} (action metodu bu şekilde çağrılıyor)

app.Run();
