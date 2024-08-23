using FluentValidation;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Ni.Alfacredit.Core.Manager.Api.Application.Behaviors;
using MediatR;

namespace Ni.Alfacredit.Core.Manager.Api.Application
{
   public static class ConfigureServices
   {
      public static IServiceCollection AddApplicationServices(this IServiceCollection services)
      {
         services.AddAutoMapper(Assembly.GetExecutingAssembly());
         services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
         services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

         services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviors<,>));         
         return services;
      } 
   }
}
