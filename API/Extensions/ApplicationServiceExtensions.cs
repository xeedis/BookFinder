using API.Helpers;
using API.Interfaces;
using API.Services;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<GoogleSettings>(config.GetSection("GoogleApiSettings"));
        services.AddScoped<IGoogleApiService, GoogleApiService>();
        services.AddScoped<BookMapper>();
        return services;
    }
}
