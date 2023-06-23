using EducationalPlatformITCube.Inspector.Web.Server.Pages.Classes;
using Google.Apis.Sheets.v4;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient<EducationalPlatformITCube.Inspector.Web.Server.Controllers.SheetsController>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5172/api/"); // Укажите базовый адрес вашего API);
});

//client =>
//{
//    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
//}

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5172/") });

builder.Services.AddControllers();
builder.Services.AddSingleton(typeof(GoogleSheetsHelper));
builder.Services.AddSingleton(typeof(SendMail));
builder.Services.AddSingleton(typeof(DB));



var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapControllers();
app.MapFallbackToPage("/_Host");
app.MapFallbackToPage("/request", "/RequestPage");


app.Run();

