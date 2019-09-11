using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LineOnCode.Store.IoCDI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LineOnCode.Store.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.Init();
            services.AddSwaggerGen(options => options.SwaggerDoc(
                "v1", 
                new Swashbuckle.AspNetCore.Swagger.Info()
                                                        {
                                                            Title = "Line on Code Api",
                                                            Version = "v1"
                                                        }
            ));
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options =>
            {
                options.AllowAnyOrigin();
                options.AllowAnyMethod();
                options.AllowAnyHeader();
            });
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(options => {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Line on Code API");
                options.RoutePrefix = "docs";
            });
        }
    }
}
