using CankutayUcarCV.Business.IOC.Microsoft;
using CankutayUcarCV.Business.Mapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// AddFluentValidation() direk modelstate üzerinden alabiliyoruz
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation().AddFluentValidation();
builder.Services.AddAutoMapper(typeof(YeteneklerProfile));
builder.AddInjections();

//services authentication added
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(c =>
    {
        c.Cookie.HttpOnly = true; // tarayıcıdaki cookie gostermeyi kapatır
        c.Cookie.Name = "CankutayUcarCV"; // tarayıcıdaki gosterilecek isim
        c.Cookie.SameSite = SameSiteMode.Strict; // diğer tarayıcılara cookie kullanımını kapatır
        c.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest; // http ve https de çalışır
        c.ExpireTimeSpan = TimeSpan.FromDays(20); // kullanıcının 20 gün boyunda cookide saklanır
        
        // authenticate and authorizate işlemleri
        c.LoginPath = new PathString("/Auth/Login/");
        c.AccessDeniedPath = new PathString("/Home/Index/");
        c.LogoutPath = new PathString("/Home/Index/");
        c.Validate();
    }); 


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthorization();

app.UseEndpoints(end =>
{
    end.MapAreaControllerRoute(
        name: "AdminArea",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}");
    end.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
