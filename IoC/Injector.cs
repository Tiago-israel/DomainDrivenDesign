using Aplication.AutoMapper;
using Aplication.Interfaces;
using Aplication.Services;
using AutoMapper;
using Infra.Interfaces.Base;
using Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    public class Injector
    {
        public static void InjetarDependencias(IServiceCollection services)
        {
            //infra
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            //Aplication
            services.AddScoped<IPessoaService, PessoaService>();
        }
    }
}
