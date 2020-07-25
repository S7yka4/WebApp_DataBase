using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.Extensions.Configuration;
using ElectronicShop.Storage;
using Microsoft.EntityFrameworkCore;
using ElectronicShop.Managers.Devices;
using ElectronicShop.Managers.Costs;
using ElectronicShop.Managers.BattaryFeatures;
using ElectronicShop.Managers.Features;
using ElectronicShop.Managers.Categories;
using ElectronicShop.Managers.PlacesInTop;
using ElectronicShop.Managers.ResponsibleConsultants;

namespace ElectronicShop
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;

        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnviroment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnviroment.ContentRootPath).AddJsonFile("DevicesDBSettings.json").Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DevicesDataContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("DevicesDB")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<IDeviceManager, DeviceManager>();
            services.AddTransient<ICostManager, CostManager>();
            services.AddTransient<IBattaryFeatureManager, BattaryFeatureManager>();
            services.AddTransient<IFeaturesManager, FeaturesManager>();
            services.AddTransient<ICategoryManager, CategoryManager>();
            services.AddTransient<IPlaceInTopManager, PlaceInTopManager>();
            services.AddTransient<IResponsibleConsultantManager, ResponsibleConsultantManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller=Device}/{action=Output}/{id?}");
            });
        }
    }
}
