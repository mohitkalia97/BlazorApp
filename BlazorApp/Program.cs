using BlazorApp.Components;
using MongoDB.Driver;
using BlazorApp.DB;
using BlazorApp.Models;
using MongoDB.Bson;
using static BlazorApp.Globals;
using BlazorApp.Services;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Services.Interfaces;


Book book1 = new Book()
{
    _title = "Herr der Ringe",
    _description = "Gutes Buch",
    _created = DateTime.UtcNow
};

Book book2 = new Book()
{
    _title = "Herr der Ringe",
    _description = "Gutes Buch",
    _created = DateTime.UtcNow
};

Book book3 = new Book()
{
    _title = "Herr der Ringe",
    _description = "Gutes Buch",
    _created = DateTime.UtcNow
};

Book book4 = new Book()
{
    _title = "Herr der Ringe",
    _description = "Gutes Buch",
    _created = DateTime.UtcNow
};

Book book5 = new Book()
{
    _title = "Herr der Ringe",
    _description = "Gutes Buch",
    _created = DateTime.UtcNow
};

var bookArray = new[]
{
    book1, book2, book3, book4, book5
};
//db.Books.AddRange(bookArray);



//db.SaveChanges();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BookDbContext>(option =>
{
    option.UseMongoDB(connectionString, "testdb");
});

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();



builder.Services.AddTelerikBlazor();

builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
