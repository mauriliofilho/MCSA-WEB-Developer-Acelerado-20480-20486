using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LineOnCode.Store.Data.EF;
using LineOnCode.Store.Data.EF.Repositories;
using LineOnCode.Store.Domain.Contracts.Repositories;
using LineOnCode.Store.IoCDI;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LineOnCode.Store.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.Filters.Add(typeof(Infra.GlobalExceptionFilter)));
            services.AddAuthentication(configureOptions =>
            {
                configureOptions.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                configureOptions.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                configureOptions.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(configureOptions => configureOptions.LoginPath = "/auth/signin" );

            services.Init();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, StoreDataContext ctx)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                ctx.Database.EnsureCreated();
            }

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes => {
                routes.MapRoute("about", "sobre", new { controller = "Home", action = "About" });
                routes.MapRoute("edit", "{controller}/Editar/{id}", new { action = "AddEdit" });
                routes.MapRoute("add", "{controller}/Adicionar", new { action = "AddEdit" });

                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
