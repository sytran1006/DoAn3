using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Project1.DatabaseContext;
using Project1.Interface;
using Project1.Models;
using Project1.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ReactContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DataContext")));
builder.Services.AddScoped<IProductPopularService, ProductPopularService>();
builder.Services.AddScoped<IListProductService, ListProductService>();
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); 

app.Run();
