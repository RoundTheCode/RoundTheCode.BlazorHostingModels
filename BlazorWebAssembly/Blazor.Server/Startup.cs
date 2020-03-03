using API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors(setup =>
            {
                // Set up our policy name
                setup.AddPolicy("AllowRoundTheCode", policy =>
                {
                    policy.WithOrigins(new string[] { "https://localhost:9001" }).AllowAnyMethod().AllowAnyHeader().AllowCredentials(); // Allow everyone
                });
            });

            services.AddSingleton<ILanguageService, LanguageService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("AllowRoundTheCode"); // This has to sit above UseEndpoints to work

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
