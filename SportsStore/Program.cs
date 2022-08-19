var builder = WebApplication.CreateBuilder(args); // making web app
builder.Services.AddControllersWithViews();


var app = builder.Build();

//middlewares
app.UseStaticFiles();
app.MapDefaultControllerRoute();
//app.MapGet("/", () => "Hello World!");
app.Run();
