using BlazorApp.DB;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Services.Interfaces;
using BlazorApp.Services;

namespace BlazorApp.Extensions
{
    public static class Extensions
    {
        public static void AddDBContext(this IHostApplicationBuilder builder)
        {
            builder.Services.AddDbContext<BookDbContext>(option =>
            {
                option.UseMongoDB(builder.Configuration["MongoDB:ConnectionString"], builder.Configuration["MongoDB:DatabaseName"]);
            });
        }

        public static void AddBAService(this IHostApplicationBuilder builder)
        {
            builder.Services.AddTelerikBlazor();
            builder.Services.AddScoped<IBookService, BookService>();
        }

    }
}
