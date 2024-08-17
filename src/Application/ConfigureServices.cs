using FluentValidation;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Ni.Alfacredit.Core.Manager.Api.Application
{
   public static class ConfigureServices
   {
      public static IServiceCollection AddApplicationServices(this IServiceCollection services)
      {
         services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
         services.AddAutoMapper(Assembly.GetExecutingAssembly());
         services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

         return services;
      } 
   }
}
