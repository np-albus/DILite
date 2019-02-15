using System;
using DILite.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace DILite.Extensions
{
    internal static class DIServiceAttributeExtensions
    {
        public static void Apply(this DIServiceAttribute attribute, Type classType, IServiceCollection services)
        {
            if (attribute.RegisterType.IsInterface())
            {
                AddInterface(services, attribute.LifeCycle, classType);
            }
            else if (attribute.RegisterType.IsClass())
            {
                AddClass(services, attribute.LifeCycle, classType);
            }
        }

        private static void AddInterface(IServiceCollection services, DIServiceLifeCycle lifeCycle, Type classType)
        {
            var interfaceType = classType.GetInterface($"I{classType.Name}");
            if (lifeCycle.IsScoped())
            {
                services.AddScoped(interfaceType, classType);
            }
            else if (lifeCycle.IsTransient())
            {
                services.AddTransient(interfaceType, classType);
            }
            else if (lifeCycle.IsSingleton())
            {
                services.AddSingleton(interfaceType, classType);
            }
        }

        private static void AddClass(IServiceCollection services, DIServiceLifeCycle lifeCycle, Type classType)
        {
            if (lifeCycle.IsScoped())
            {
                services.AddScoped(classType);
            }
            else if (lifeCycle.IsTransient())
            {
                services.AddTransient(classType);
            }
            else if (lifeCycle.IsSingleton())
            {
                services.AddSingleton(classType);
            }
        }
    }
}
