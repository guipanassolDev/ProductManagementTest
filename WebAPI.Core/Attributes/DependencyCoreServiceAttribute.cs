using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.Attributes
{
    public class DependencyCoreServiceAttribute : Attribute
    {
        public ServiceLifetime ServiceLifetime { get; }

        public Type Type { get; }

        public DependencyCoreServiceAttribute(Type type = null, ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            ServiceLifetime = serviceLifetime;
            Type = type;
        }

        public static void AddDependecies(IServiceCollection services)
        {
            var types = AppDomain.CurrentDomain
               .GetAssemblies()
               .SelectMany(s => s.GetTypes())
               .Where(c =>
                   c.IsClass &&
                   !c.IsAbstract &&
                   c.IsDefined(typeof(DependencyCoreServiceAttribute), true));

            foreach (var implemType in types)
            {
                var attr = implemType.GetCustomAttribute<DependencyCoreServiceAttribute>(true);

                switch (attr.ServiceLifetime)
                {
                    case ServiceLifetime.Singleton:
                        services.AddSingleton(attr.Type ?? implemType, implemType);
                        break;
                    case ServiceLifetime.Transient:
                        services.AddTransient(attr.Type ?? implemType, implemType);
                        break;
                    case ServiceLifetime.Scoped:
                    default:
                        services.AddScoped(attr.Type ?? implemType, implemType);
                        break;
                }
            }
        }
    }
}
