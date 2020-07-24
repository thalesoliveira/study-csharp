using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomCesarPizza.Data;
using DomCesarPizza.Data.Repository;
using DomCesarPizza.Domain.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DomCesarPizza.Api
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
            services.AddControllers();

            //services.AddScoped(typeof(IRepositoryBase<>)), typeof(RepositoryBase);
            //services.AddScoped<IAgendaCardapioRepository, AgendaCardapioRepository>();
            //services.AddScoped<IAgendaRepository, AgendaRepository>();
            //services.AddScoped<ICardapioRepository, CardapioRepository>();
            //services.AddScoped<IIngredienteRepository, IngredienteRepository>();
            //services.AddScoped<IPizzaIngredientesRepository, PizzaIngredientesRepository>();
            //services.AddScoped<IPizzaRepository, PizzaRepository>();
            //services.AddScoped<ITipoPizzaCardapioRepository, TipoPizzaRepository>();

            services.AddDbContext<Contexto>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("development")));
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
        }
    }
}
