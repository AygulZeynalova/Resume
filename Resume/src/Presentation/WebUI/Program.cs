using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Resume.Models.Entities;
using Services;
using Services.Common;
using Services.Implementation;

namespace Resume
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddRouting(cfg => cfg.LowercaseUrls = true);

            builder.Services.AddDbContext<DbContext, DataContext>(cfg =>
            {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"), opt =>
                {
                    opt.MigrationsHistoryTable("MigrationHistory");
                });
            }
           );
            builder.Services.AddSingleton<ICryptoService, CryptoService>();
            builder.Services.AddScoped< IContactPostService, ContactPostService > ();

            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(name: "areas",
            pattern: "{area:exists}/{controller=DashBoard}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=index}/{id?}");

            app.Run();
        }
    }
}


