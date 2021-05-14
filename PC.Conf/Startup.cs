using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PCConf.Data;
using PCConf.Data.Seeding;
using PCConf.Domain.Repositories;
using PCConf.Domain.Services;
using PCConf.Repositories;
using PCConf.Services;

namespace PCConf
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

            services.AddScoped<IPartService, PartService>();

            services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            DbSeeder.CreateDbAndSampleData(app.ApplicationServices);
        }
    }
}
