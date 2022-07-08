
using DependencyInjection.Demo;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//addtranscient for dependency injection
//new instance everytime we ask for it
builder.Services.AddTransient<ILogic, Logic>();
builder.Services.AddTransient<IBetterlogic, BetterLogic>();

//singleton for everyone, keep instance for each person
builder.Services.AddScoped<Logic>();

// we have a new instance which is similar eveywhere even if we copy the same url
builder.Services.AddSingleton<Logic>();



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
app.MapFallbackToPage("/_Host");

app.Run();
