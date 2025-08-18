using Application.Services;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using Infrastructure.Data;
using Infrastructure.Repositories;



namespace Presentation
{

    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddDbContext<Infrastructure.Data.ApplicationDbContext>(options =>
                        options.UseSqlServer("Server=.;Database=CafeDb;Trusted_Connection=True;TrustServerCertificate=True"));

                    services.AddScoped<CafeRestaurant.Domain.Repositories.IOrderRepository,
                                       CafeRestaurant.Infrastructure.Repositories.OrderRepository>();

                    services.AddTransient<MainForm>();  // Form adın farklıysa onu yaz
                })
                .Build();

            using var scope = host.Services.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(form);
        }
    }
}

