using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewWebShopStream.Domain.Intefaces;
using NewWebShopStream.Domain.Models;
using NewWebShopStream.Domain.Repositories;
using NewWebShopStream.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new Config());

            //підключаємо контекст БД
            services.AddDbContext<AppDbContext>(c => c.UseSqlServer(Config.ConnectionString));

            //підключаємо наші репозиторії і клас управління ними
            services.AddTransient<IServiceItemRepository, ServiceItemRepository>();
            services.AddTransient<ITextFieldRepository, TextFieldRepository>();
            services.AddTransient<DataManager>();

            //Добавляємо Identity
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                //так не потрібно робити якщо що
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //настройка куків
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "MyCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });


            //настройка політики авторизаії
            services.AddAuthorization(c =>
            {
                c.AddPolicy("AdminArea", policy => policy.RequireRole("Admin"));
            });


            services.AddControllersWithViews(
                c =>
                {
                    c.Conventions.Add(new AdminAreaAuthorizathion("Admin", "AdminArea"));
                }
                ).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();
        }


               

         

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();
            


            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //створюємо адмінку по-суті
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
