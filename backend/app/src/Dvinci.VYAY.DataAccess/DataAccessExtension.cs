using Dvinci.VYAY.Common.Configs;
using Dvinci.VYAY.DataAccess.Subscriptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dvinci.VYAY.DataAccess;

public static class DataAccessExtension
{
    public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var postgresDbConfig = configuration.GetSection(PostgresDbConfig.SectionName).Get<PostgresDbConfig>();
        postgresDbConfig!.ValidateConfig();

        services.AddDbContext<VyayDataContext>(option => option.UseNpgsql(postgresDbConfig.ConnectionString));
    }
    public static void RegisterDataAcess(this IServiceCollection services)
    {
        services.AddTransient<IVyayDao, VyayDao>();
        services.AddTransient<ISubscriptionDao, SubscriptionDao>();
    }

    public static void EnsureDatabaseCreated(this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var scopedServiceProvider = scope.ServiceProvider;
        var vyayDao = scopedServiceProvider.GetRequiredService<IVyayDao>();
        vyayDao.EnsureCreated();
    }
}
