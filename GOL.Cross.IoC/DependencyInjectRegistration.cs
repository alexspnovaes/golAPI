using GOL.Database.Context;
using GOL.Database.Repositories;
using GOL.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GOL.Cross.IoC
{
    public class DependencyInjectRegistration
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Repository
            services.AddScoped<IAirplaneRepository, AirplaneRepository>();

            //services.AddScoped<IUnitOfWork>

            services.AddDbContext<GolContext>(opt => opt.UseInMemoryDatabase("golDatabase", null));


        }
    }
}
