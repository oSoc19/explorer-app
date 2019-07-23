using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using backend.DAL;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.Rewrite;
using backend.Infrastructure;
using System;

namespace backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the 
        //container.
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigurationHelper helper = new ConfigurationHelper("secret.json");
            string server = helper.Get("server");
            string database = helper.Get("database");
            string user = helper.Get("user");
            string password = helper.Get("password");
            string connectionString = "server="+server+";"+"database="+database+";"+"user="+user+";"+"password="+password+";";
            services.AddDbContext<ExplorerContext>(opt =>
                opt.UseLazyLoadingProxies()
                .UseSqlServer(connectionString));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddCors();
            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Info { Title = "Explorer API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP 
        //request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ExplorerContext context)
        {

            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for 
                // production scenarios, see https://aka.ms/aspnetcore-hsts.
               app.UseHsts();
            }

            app.UseCors(builder => 
            {
                builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });

            app.UseHttpsRedirection();
            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");
            option.AddRedirect("^api/?$", "swagger");
            app.UseRewriter(option);
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c => {
               c.SwaggerEndpoint("/swagger/v1/swagger.json", "Explorer API v1");
             });
        }
    }
}