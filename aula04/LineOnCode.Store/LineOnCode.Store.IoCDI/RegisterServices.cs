using LineOnCode.Store.Data.EF;
using LineOnCode.Store.Data.EF.Repositories;
using LineOnCode.Store.Domain.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineOnCode.Store.IoCDI
{
    public static class RegisterServices
    {
        public static void Init(this IServiceCollection services)
        {
            //Unico na Aplicacao
            //services.AddSingleton<StoreDataContext>();
            //Unico em toda a requisicao mais indicado deve no final dar um unico savchanges!
            services.AddScoped<StoreDataContext>();
            //Gera um sempre que for requisitado ou toda vez que foi utilizado
            //services.AddTransient<StoreDataContext>();

            services.AddTransient<IProdutoRepository, ProdutoRepositoryEF>();
            services.AddTransient<ICategoriaRepository, CategoriaRepositoryEF>();
            services.AddTransient<IUsuarioRepository, UsuarioRepositoryEF>();
        }
    }
}
