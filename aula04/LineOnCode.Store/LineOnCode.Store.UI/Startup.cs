using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LineOnCode.Store.Data.EF;
using LineOnCode.Store.Data.EF.Repositories;
using LIneOnCode.Store.Domain.Contracts.Repositories;
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
            services.AddMvc();

            //Unico na Aplicacao
            //services.AddSingleton<StoreDataContext>();
            //Unico em toda a requisicao mais indicado deve no final dar um unico savchanges!
            services.AddScoped<StoreDataContext>();
            //Gera um sempre que for requisitado ou toda vez que foi utilizado
            //services.AddTransient<StoreDataContext>();

            services.AddTransient<IProdutoRepository, ProdutoRepositoryEF>();
            services.AddTransient<ICategoriaRepository, CategoriaRepositoryEF>();
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
            app.UseMvc(routes => {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
