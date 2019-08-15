using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GearShopV2.Data;
using GearShopV2.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace GearShopV2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //   services.AddIdentity<IdentityUser, IdentityRole>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            //Changed adddefaultidentity to addidentity and swapped out application user for the original IdentityUser param
            //Because changing adddefaultidentity to addidentity did not give me error when adding identityRole as param
            services.AddIdentity<ApplicationUser, IdentityRole>(options => { })
                .AddEntityFrameworkStores<ApplicationDbContext>();
            //    .AddDefaultTokenProviders()
            //REMOVED THESE BECAUSE OF THE MIGRATION INSTRUCTIONS FROM MICROSOFT DOCS
            //THEY WERE NOT SHOWN IN THE COOKIBASED AUTHENTICATION EXAMPLES
           //      .AddDefaultUI(UIFramework.Bootstrap4)
           //      .AddRoles<IdentityRole>();
            //
            //ALSO ADDED THIS STATEMENT FROM THE MICROSOFT EXAMPLE DOCS THE COOKIE
            //----------------------------------------------------
            // services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/LogIn");


            //-------------------------------------------------
            //ADDED THIS FROM THE IDENTITY DEEP DIVE COURSE
            //--------------------------------------------
            services.AddScoped<IUserStore<ApplicationUser>,
            UserOnlyStore<ApplicationUser, ApplicationDbContext>>();


            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });

           // services.AddMemoryCache();
           // services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
          //  app.UseSession();
          //  app.UseIdentity();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
