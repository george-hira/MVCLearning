using System.Net.Mime;

using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// first part reffers the name of the controller 
// second part reffers to the name of action method 
// third part is optional and it reffers to the paramether of the action method 
app.Run();



