using Dvinci.VYAY.DataModel.Subscription;
using Microsoft.Extensions.DependencyInjection;

namespace Dvinci.VYAY.DataAccess.Subscriptions;

public class SubscriptionDao : ISubscriptionDao
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public SubscriptionDao(
        IServiceScopeFactory serviceScopeFactory    
        )
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public async Task<bool> SaveAsync(SubscriptionItem item, CancellationToken cancellationToken = default)
    {
        using (var scope = _serviceScopeFactory.CreateScope()) 
        {
            var vyayDao = scope.ServiceProvider.GetRequiredService<IVyayDao>();
            using (var dataContext = vyayDao.GetContext())
            {
                dataContext.Subscriptions.Add(item);
                await dataContext.SaveChangesAsync();
                return true;
            }
        }
    }
}
