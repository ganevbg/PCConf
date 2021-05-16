using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PCConf.Data;
using PCConf.Domain.Repositories;
using PCConf.Domain.Services;
using PCConf.Repositories;
using PCConf.Services;

namespace PCConf.Web
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            // Add the Kendo UI services to the services container.
            services.AddKendo();

            services.AddDbContext<AppContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });

            services.AddScoped<IProcessorRepository, ProcessorRepository>();
            services.AddScoped<IMotherBoardRepository, MotherBoardRepository>();
            services.AddScoped<IRamRepository, RamRepository>();
            services.AddScoped<IVideoCardRepository, VideoCardRepository>();
            services.AddScoped<IPowerSuplyRepository, PowerSuplyRepository>();
            services.AddScoped<IPcCaseRepository, PcCaseRepository>();
            services.AddScoped<IStorageDriveRepository, StorageDriveRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();

            services.AddScoped<IProcessorService, ProcessorService>();
            services.AddScoped<IMotherBoardService, MotherBoardService>();
            services.AddScoped<IRamService, RamService>();
            services.AddScoped<IVideoCardService, VideoCardService>();
            services.AddScoped<IPowerSuplyService, PowerSuplyService>();
            services.AddScoped<IPcCaseService, PcCaseService>();
            services.AddScoped<IStorageDriveService, StorageDriveService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
