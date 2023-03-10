using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Attributes;

namespace WebAPI.Application.Services
{
    [DependencyApplicationService(serviceLifetime: ServiceLifetime.Scoped)]
    public class BaseAppService
    {
        protected readonly IServiceProvider ServiceProvider;

        public BaseAppService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        protected T GetRequiredService<T>() => ServiceProvider.GetRequiredService<T>();

        protected TDestination Map<TDestination>(object source)
        {
            var mapper = GetRequiredService<IMapper>();

            return mapper.Map<TDestination>(source);
        }
    }
}
