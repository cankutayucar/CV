using CankutayUcarCV.Business.IOC.Microsoft;
using CankutayUcarCV.Business.Mapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// AddFluentValidation() direk modelstate üzerinden alabiliyoruz
builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation()
    .AddFluentValidation()
    .AddNToastNotifyToastr();

builder.Services.AddAutoMapper(typeof(YeteneklerProfile), typeof(KullaniciProfile), typeof(Program));
builder.AddInjections();
//services authentication added
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(c =>
    {
        c.Cookie.HttpOnly = true; // tarayıcıdaki cookie gostermeyi kapatır
        c.Cookie.Name = "CankutayUcarCV"; // tarayıcıdaki gosterilecek isim
        c.Cookie.SameSite = SameSiteMode.Strict; // diğer tarayıcılara cookie kullanımını kapatır
        c.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest; // http ve https de çalışır
        c.ExpireTimeSpan = TimeSpan.FromDays(10); // kullanıcının 20 gün boyunda cookide saklanır
        
        // authenticate and authorizate işlemleri
        c.LoginPath = new PathString("/Auth/Login/");
        c.AccessDeniedPath = new PathString("/Home/error/");
        c.LogoutPath = new PathString("/Home/Index/");
    });
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // httpcontext ulasma
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseSession();
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseNToastNotify();

app.UseEndpoints(end =>
{
    end.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}");
    end.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
