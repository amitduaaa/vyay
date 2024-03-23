using Dvinci.VYAY.DataModel.Subscription;

namespace Dvinci.VYAY.DataAccess.Subscriptions;

public interface ISubscriptionDao
{
    public Task<bool> SaveAsync(SubscriptionItem item, CancellationToken cancellationToken = default);
}
