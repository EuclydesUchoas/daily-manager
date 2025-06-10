using DailyManager.Application.Meditator;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace DailyManager.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediator();
            services.RegisterFluentValidation();

            return services;
        }

        private static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddSingleton<ISender, Sender>();

            var assembly = Assembly.GetExecutingAssembly();

            var handlerInterfaceVoid = typeof(IRequestHandler<>);
            var handlerInterfaceReturn = typeof(IRequestHandler<,>);

            var handlerInterfaces = new Type[] { handlerInterfaceVoid, handlerInterfaceReturn };

            var handlerTypes = assembly.GetTypes()
                .Where(t => !t.IsAbstract && !t.IsInterface)
                .SelectMany(t => t.GetInterfaces()
                    .Where(i => i.IsGenericType && handlerInterfaces.Contains(i.GetGenericTypeDefinition()))
                    .Select(i => new { HandlerType = t, InterfaceType = i }));

            foreach (var handlerType in handlerTypes)
            {
                services.AddSingleton(handlerType.InterfaceType, handlerType.HandlerType);
            }

            return services;
        }

        private static IServiceCollection RegisterFluentValidation(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly, includeInternalTypes: true);

            return services;
        }
    }
}
