using CreateCar.Models;
using CreateCar.Repositories;
using CreateCar.Repositories.Interfaces;
using CreateCar.Services;
using Microsoft.EntityFrameworkCore;

namespace CreateCar
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddScoped<ICarRepository,CarRepository>();
            services.AddScoped<CarService>();
            services.AddDbContext<DbCarContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "CreateCar",
                    pattern: "CreateCar",
                    defaults: new { controller = "Car", action = "CreateCar" });

                endpoints.MapControllerRoute(
                   name: "GetCar",
                   pattern: "GetCar/{id}",
                   defaults: new { controller = "Car", action = "GetCar" });

                endpoints.MapControllerRoute(
                   name: "GetCars",
                   pattern: "GetCars",
                   defaults: new { controller = "Car", action = "GetCars" });

                endpoints.MapControllerRoute(
                    name: "UpdateCar",
                    pattern: "UpdateCar/{id}",
                    defaults: new { controller = "Car", action = "UpdateCar" });

                endpoints.MapControllerRoute(
                    name: "DeleteCar",
                    pattern: "DeleteCar/{id}",
                    defaults: new { controller = "Car", action = "DeleteCar" });
            });

        }
    }
}