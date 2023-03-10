using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.MongoDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.Attributes;

namespace WebAPI.Core.Services
{
    [DependencyCoreService(serviceLifetime: ServiceLifetime.Scoped)]
    public class BaseService
    {
        protected readonly IServiceProvider ServiceProvider;

        public BaseService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        protected T GetRequiredService<T>() => ServiceProvider.GetRequiredService<T>();

        protected MongoContext DbContext => GetRequiredService<MongoContext>();

        protected TDestination Map<TDestination>(object source)
        {
            var mapper = GetRequiredService<IMapper>();

            return mapper.Map<TDestination>(source);
        }
    }
}
