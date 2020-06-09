using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Marvel.Ioc;
using Marvel.Repository.Context;
using MarvelAPP.API.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MarvelAPP.API
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
            services.AddMvc();

            services.AddControllers();

            services.AddAutoMapper(Assembly.Load("Marvel.Application"));
            services
                .AddAutoMapper(Assembly.Load("Marvel.Domain"));

            services.AddScoped<ErrorExceptionFilter>();
            services.AddDbContext<MarvelContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MarvelContext"))
                .UseLazyLoadingProxies());

            services.AddControllers()
                .AddNewtonsoftJson();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "API Marvel",
                        Version = "v1",
                        Description = "API Marvel Characters, Series, Comics and Events",
                        Contact = new OpenApiContact
                        {
                            Name = "Jonas Felipe Virgilio da Silva",
                            Url = new Uri("https://github.com/jonasfelipe")
                        }
                    });

            });

            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
                endpoints.MapControllers();
            });

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "API Marvel");
            });
        }

        void RegisterServices(IServiceCollection services)
        {
            new RootBootstrapper().RootRegisterServices(services);
        }
    }
}
