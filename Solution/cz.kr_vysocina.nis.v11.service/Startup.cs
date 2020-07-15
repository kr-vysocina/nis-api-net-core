using System.Text.Json.Serialization;
using cz.kr_vysocina.nis.v11.api.Controllers;
using cz.kr_vysocina.nis.v11.core.Providers;
using cz.kr_vysocina.nis.v11.mock;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace cz.kr_vysocina.nis.v11.service
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDataProvider, MockDataProvider>(); //TODO replace by real implementation

            var assembly = typeof(NisApiV11Controller).Assembly; //Get assembly of API controller

            services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()))
                .AddApplicationPart(assembly); //Add assembly as application part to controllers

            services.AddMvc()
                .AddXmlSerializerFormatters() //Add XML serializer
                .AddApplicationPart(assembly); //Add assembly as application part to MVC

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v11", new OpenApiInfo
                {
                    Version = "v11",
                    Title = "NIS API",
                    Description = "Implementation of NIS API for national connector"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Use routing to enable Route attribute on API controller
            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v11/swagger.json", "NIS API v11");
                c.RoutePrefix = string.Empty;
            });

            //Map routes to controllers
            app.UseEndpoints(routes => { routes.MapControllers(); });
        }
    }
}