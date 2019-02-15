using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DILite.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace DILite.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services)
        {
            var classTypes = Assembly.GetEntryAssembly().GetTypes()
               .Union(Assembly.GetCallingAssembly().GetTypes())
               .Union(Assembly.GetExecutingAssembly().GetTypes())
               .Distinct()
               .Where(t => t.IsClass && !t.IsAbstract && !t.IsNested && t.CustomAttributes.Any());

            ApplyAttributes(classTypes, services);

            return services;
        }

        public static IServiceCollection AddDIServices(this IServiceCollection services, Type type)
        {
            var classTypes = Assembly.GetAssembly(type).GetTypes().Distinct()
                .Where(t => t.IsClass && !t.IsAbstract && !t.IsNested && t.CustomAttributes.Any());

            ApplyAttributes(classTypes, services);

            return services;
        }

        private static void ApplyAttributes(IEnumerable<Type> classTypes, IServiceCollection services)
        {
            foreach (var classType in classTypes)
            {
                if (Attribute.GetCustomAttribute(classType, typeof(DIServiceAttribute)) is DIServiceAttribute attribute)
                {
                    attribute.Apply(classType, services);
                }
            }
        }
    }
}
