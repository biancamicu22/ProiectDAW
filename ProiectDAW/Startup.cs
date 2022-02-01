using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ProiectDAW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectDAW.Services;
using ProiectDAW.Utilities;
using System.Text.Json.Serialization;
using ProiectDAW.Repository;
using Newtonsoft.Json;

namespace ProiectDAW
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
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            );
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProiectDAW", Version = "v1" });
            });
            services.AddControllers().AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.Configure<AppSettings>(result => result.JWTSecret = Configuration.GetValue<string>("AppSettings:Secret"));
            services.AddScoped<IJWTUtils, JWTUtils>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPortofelRepository, PortofelRepository>();
            services.AddScoped<IAtractieRepository, AtractieRepository>();
            services.AddScoped<IBiletRepository, BiletRepository>();
            services.AddScoped<ICazareRepository, CazareRepository>();
            services.AddScoped<IFacilitatiRepository, FacilitatiRepository>();
            services.AddScoped<IFotografieRepository, FotografieRepository>();
            services.AddScoped<IPachetRepository, PachetRepository>();
            services.AddScoped<IRezervareRepository, RezervareRepository>();
            services.AddScoped<IRezervareCazareRepository, RezervareCazareRepository>();
            services.AddScoped<IVacantaRepository, VacantaRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProiectDAW v1"));
            }

            app.UseCors(x => x
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseMiddleware<JWTMiddleware>();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
