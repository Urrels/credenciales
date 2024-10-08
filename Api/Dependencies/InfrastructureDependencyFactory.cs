using Application.Common.Interfaces;
using Utility.ServiceErrorHandlers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Api.Services;
using Utility.PasswordHasher;

namespace Api.Dependencies
{
    public static class InfrastructureDependencyFactory
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IErrorServiceProvider, ErrorServiceProvider>();
            services.AddTransient<IPasswordHasherService, PasswordHasherService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<ValidationActionFilter>();
        }

    }
}