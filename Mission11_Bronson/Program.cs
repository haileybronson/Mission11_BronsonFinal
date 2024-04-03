using Microsoft.EntityFrameworkCore;
using Mission11_Bronson.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BookstoreContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:BookstoreConnection"]);
});

builder.Services.AddScoped<IBookstoreRepository, EFBookstoreRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//order matters, it will take the first one without looking at the second
app.MapControllerRoute("pagenumandtype", "{bookType}/{pageNum}", new { Controller = "Home", action = "Index" });
app.MapControllerRoute("bookType", "{bookType}", new { Controller = "Home", action = "Index", pageNum = 1 });
app.MapControllerRoute("pagination", "Books/{pageNum}", new {Controller = "Home", action ="Index", pageNum = 1});


app.MapDefaultControllerRoute();
app.Run();
