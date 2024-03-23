using Dvinci.VYAY.Common.Configs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dvinci.VYAY.Common.Extensions;

public static class ConfigsCollectionExtension
{
    public static void RegisterConfigs(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<PostgresDbConfig>(configuration.GetSection(PostgresDbConfig.SectionName));
    }

    public static IConfigurationBuilder RegisterAppSettings(this IConfigurationBuilder builder, string environment, string filename = "appsettings")
    {
        if (environment == "Development")
        {
            return builder.AddJsonFile($"{filename}.json", true, true)
                .AddJsonFile($"{filename}.Development.json", true, true);
        }

        return builder.AddJsonFile($"{filename}.json", true, true);
    }
}
