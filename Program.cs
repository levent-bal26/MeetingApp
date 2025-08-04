var builder = WebApplication.CreateBuilder(args);

// mvc şablonu için aşağıdaki ifade yazılıyor.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// mvc
// rest api
// razor page

app.MapGet("/", () => "Hello World!");

app.MapGet("/abc", () => "deneme");

app.Run();
