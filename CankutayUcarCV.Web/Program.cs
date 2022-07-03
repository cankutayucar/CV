using CankutayUcarCV.Business.IOC.Microsoft;
using CankutayUcarCV.Business.Mapper;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// AddFluentValidation() direk modelstate üzerinden alabiliyoruz
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation().AddFluentValidation();
builder.Services.AddAutoMapper(typeof(YeteneklerProfile));
builder.AddInjections();

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
