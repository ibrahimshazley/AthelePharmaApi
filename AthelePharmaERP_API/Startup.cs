using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AthelePharmaERP_API.Models.Entities;
using AthelePharmaERP_API.Repositories.Abstraction;
using AthelePharmaERP_API.Repositories.Implementations;
using AthelePharmaERP_API.Repositories.IRepositories;
using AthelePharmaERP_API.Repositories.Repositories;
using AthelePharmaERP_API.Services.Abstraction;
using AthelePharmaERP_API.Services.Implementations;
using AutoMapper;
using CheckTime.AutoMapperProfiler;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AthelePharmaERP_API
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
            services.AddDbContext<PharmaERPTestContext>(ctx => { ctx.UseSqlServer(Configuration["ConnectionStrings:SqlServerConnectionString"]); });

            services.AddControllers();
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IBaseRepository, BaseRepository>();
            services.AddTransient<IPemission_RequestService, Permission_RequestService>();


            services.AddCors();
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
        }
    }
}
