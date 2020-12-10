using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Search.POC.API.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Search.POC.API.Service;

namespace Search.POC.API
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
            services.AddCors(options =>
            {
                options.AddPolicy("CORS",
                    cors => cors
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        //.AllowCredentials()
                        );
            });

            services
                .AddDbContext<PheonixDbContext>(options => options.UseSqlServer(
                        Configuration.GetConnectionString("PheonixDB"))
                    .EnableDetailedErrors().EnableSensitiveDataLogging(), ServiceLifetime.Scoped);

            services.AddTransient<IService, SearchService>();

            services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });
            //services.AddEntityFrameworkSqlServer();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Search.POC.API", Version = "v1" });
            });

            services.AddMvc(config =>
            {
                config.RespectBrowserAcceptHeader = true;
            })
             .AddNewtonsoftJson(options =>
             {
                 options.SerializerSettings.ContractResolver = new JsonContractResolver(new JsonMediaTypeFormatter());
                 options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                 options.SerializerSettings.MaxDepth = 1;
             })
            .SetCompatibilityVersion(CompatibilityVersion.Latest);
            // all route data should be lower cased
            services.AddRouting(options => options.LowercaseUrls = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Search.POC.API v1"));
            }
            app.UseCors("CORS");
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
