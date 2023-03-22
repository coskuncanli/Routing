using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.UseEndpoints(endpoints => {
//    endpoints.MapControllerRoute(
//        name:"güncel",
//        pattern: "GuncelHaberler",
//        defaults: new { controller = "Haber", action = "Guncel" });
//    endpoints.MapControllerRoute(
//        name: "hava",
//        pattern: "HavaDurumu",
//        defaults: new { controller = "Haber", action = "HavaDurumu" });
//    endpoints.MapControllerRoute(
//        name: "spor",
//        pattern: "SporHaberleri",
//        defaults: new { controller = "Haber", action = "Spor" });
//    endpoints.MapControllerRoute(
//        name:"home",
//        pattern: "Anasayfa",
//        defaults: new {controller = "Home", action="Index"});
//    endpoints.MapControllerRoute(
//        name: "gizlilk",
//        pattern: "Gizlilik",
//        defaults: new { controller = "Home", action = "Privacy" });
//});

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();
