using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using projekt.Data;
using projekt.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System;
using System.Linq;


namespace projekt
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
            services.AddDbContext<ApplicationDbContext>();
            services.AddScoped<HomeControllerService>();
    }


    // Metoda Configure będzie konfigurować wszystkie niezbędne metody przepływu, przez które musi przejść zapytanie z API przed zwróceniem odpowiedzi
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Powoduje to, że jeśli klient API wyśle zapytanie bez protokołu https, to jego zapytanie automatycznie zostanie przekierowane na adres
            // z protokołem https
            app.UseHttpsRedirection();

            app.UseRouting();

            // Poprzez atrybut Route w HomeController nasze zapytanie zostanie zmapowane do wywołania w kontrolerze
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }

    }
}
