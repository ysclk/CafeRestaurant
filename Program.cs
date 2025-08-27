using System;
using System.Windows.Forms;

namespace CafeRestaurant

{
    using CafeRestaurant.Forms;
    using CafeRestaurant.Models;
    using CafeRestaurant.Repositories;
    using CafeRestaurant.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System.Web.UI.WebControls;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new AdminForm(2));
        //}
        public static IServiceProvider serviceProvider;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);        
          
        
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();

            //// Resolve the factory and create AdminForm with a specific userId
            var adminFormFactory = serviceProvider.GetService<Func<int, AdminForm>>();
            var adminForm = adminFormFactory(26); // Pass the userId here (e.g., 123)
            //                                      // Resolve the factory and create AdminForm with a specific userId
            Application.Run(adminForm);

           // Application.Run(serviceProvider.GetService<LoginForm>());

        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // DB Context'i scoped olarak ekle
            services.AddScoped<CafeRestaurantEntities>();

            // Repository'ler
            services.AddScoped<CategoryRepository>();
            services.AddScoped<ProductRepository>();
            services.AddScoped<UserRepository>();
            services.AddScoped<StockRepository>();
            services.AddScoped<OrderRepository>();
            services.AddScoped<OrderDetailsRepository>();
            services.AddScoped<OrderStatusRepository>();
            services.AddScoped<StockTransactionRepository>();
            services.AddScoped<UserRoleRepository>();

            // Servisler
            services.AddScoped<LoginService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<OrderDetailService>();
            services.AddScoped<OrderService>();
            services.AddScoped<OrdersViewService>();
            services.AddScoped<ProductService>();
            services.AddScoped<ReportService>();
            services.AddScoped<StockService>();
            services.AddScoped<UserroleService>();
            services.AddScoped<UserService>();


            // Form

            services.AddScoped<AdminForm>();
            services.AddScoped<Func<int, AdminForm>>(provider => userId =>
            {
                return ActivatorUtilities.CreateInstance<AdminForm>(provider, userId);
            });
            services.AddScoped<CategoryForm>();
            services.AddScoped<DashboardAdminForm>();
            services.AddScoped<Func<int, DashboardAdminForm>>(provider => userId =>
            {
                return ActivatorUtilities.CreateInstance<DashboardAdminForm>(provider, userId);
            });
            services.AddScoped<LoginForm>();
            services.AddScoped<OrderActionForm>();
            services.AddScoped<OrderForm>();
            services.AddScoped<Func<int, OrderForm>>(provider => userId =>
            {
                return ActivatorUtilities.CreateInstance<OrderForm>(provider, userId);
            });
            services.AddScoped<OrdersViewForm>();
            services.AddScoped<PasswordChangeForm>();
            services.AddScoped<Func<int,string, PasswordChangeForm>>(provider => (userId,userEmail) =>
            {
                return ActivatorUtilities.CreateInstance<PasswordChangeForm>(provider, userId,userEmail);
            });
            services.AddScoped<ProductForm>();
            services.AddScoped<ReportsForm>();
            services.AddScoped<ResetPasswordForm>();
            services.AddScoped<UserForm>();
        }
    }
}
