using LoginAPI.Application.Services;
using LoginAPI.Data.Contexts;
using LoginAPI.Data.Repository;
using LoginAPI.Domain.Clientes;
using LoginAPI.EF.Config;
using LoginAPI.EF.Services;
using Microsoft.EntityFrameworkCore;

namespace LoginAPI.Config
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IClienteAppService, ClienteService>();

            services.AddScoped<IClienteRepository, ClienteRepository>();

            return services;
        }

        public static IApplicationBuilder UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseIdentityConfiguration();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }
    }
}
