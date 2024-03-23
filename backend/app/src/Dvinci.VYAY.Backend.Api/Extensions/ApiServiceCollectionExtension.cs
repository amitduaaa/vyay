using Dvinci.VYAY.Backend.Api.Apis;

namespace Dvinci.VYAY.Backend.Api.Extensions;

public static class ApiServiceCollectionExtension
{
    public static void RegisterApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IApi, HealthApi>();
        services.AddTransient<IApi, SubscriptionApi>();

        services.AddLogging();
        services.AddHttpClient();
    }
}
