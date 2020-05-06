using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using DigiMoallem.DAL.Context;
using DigiMoallem.BLL.Helpers.EmailServices;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.BLL.Services;

namespace DigiMoallem.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddAuthentication(options => 
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options => 
            {
                options.LoginPath = "/Login";
                options.LogoutPath = "/Logout";
                options.ExpireTimeSpan = TimeSpan.FromHours(720); // cookie expiration time: one month
            });

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            // user service
            services.AddTransient<IUserService, UserService>();

            // email service
            services.AddTransient<IViewRenderService, RenderViewToString>();

            // permission service
            services.AddTransient<IPermissionService, PermissionService>();

            services.AddTransient<ICourseService, CourseService>();

            services.AddTransient<IOrderService, OrderService>();

            services.AddTransient<ISettingService, SettingService>();

            services.AddTransient<IAccountingService, AccountingService>();

            services.AddTransient<IMessageService, MessageService>();

            services.AddTransient<IWorkService, WorkService>();

            services.AddTransient<IStandardService, StandardService>();

            services.AddTransient<IDiscountPerCourseService, DiscountPerCourseService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
