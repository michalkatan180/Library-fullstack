using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Proxies;
using BLL.cast;

namespace project
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
            services.AddCors(options =>
              {
                  options.AddPolicy(name: "myPolicy", builder =>
                  {
                      // builder.WithOrigins("http://localhost:4200").WithMethods("GET", "PUT", "POST", "DELETE");
                      builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                  });
              });
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());//הגדרת הממיר האוטומטי
            services.AddAutoMapper(typeof(AotoMapperProfile));
            services.AddDbContext<Library>(
              option => option.UseLazyLoadingProxies().UseSqlServer
              ("Data Source=DESKTOP-DTDQQNG;" + "Initial Catalog=library;" +
              "Integrated Security=True"));

            services.AddScoped<BLL.Book>();
            services.AddScoped<BLL.Borrower>();
            services.AddScoped<BLL.Category>();
            services.AddScoped<BLL.Lending>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();


            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors("myPolicy");

            app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

        }
    }
}
