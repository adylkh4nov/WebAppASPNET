using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using WebApp.Models;
using WebApp;
using Hotel.ATR.Portal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//// Настройка локализации
//builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

//builder.Services.AddControllersWithViews()
//	.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
//	.AddDataAnnotationsLocalization();

//builder.Services.AddHttpContextAccessor();

// Регистрация вашей службы IRepository
//builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddMvc();

////Logging
builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
builder.Logging.AddConsole();

//// Настройка аутентификации и авторизации
//builder.Services.AddAuthentication("MyAuthenticationScheme")
//	.AddCookie("MyAuthenticationScheme", options =>
//	{
//		options.Cookie.Name = "MyAuthCookie";
//		options.LoginPath = "/Account/Login"; // Путь к странице входа
//	});

// подключение к базе данных, строка подключения из appsettings
builder.Services.AddDbContext<WebAppContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Logger.LogError("Test");
app.Run();
