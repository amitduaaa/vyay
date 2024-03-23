using Dvinci.VYAY.DataModel.Subscription;

namespace Dvinci.VYAY.DomainLogic.Subscription;

public interface ISubscriptionService
{
    public Task<bool> SaveAsync(string userId, SubscriptionItem request, CancellationToken cancellationToken = default);
}
