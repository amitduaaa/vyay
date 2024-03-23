using Dvinci.VYAY.DataAccess.Subscriptions;
using Dvinci.VYAY.DataModel.Subscription;
using Microsoft.Extensions.Logging;

namespace Dvinci.VYAY.DomainLogic.Subscription;

public class SubscriptionService : ISubscriptionService
{
    private readonly ILogger<SubscriptionService> _logger;
    private readonly ISubscriptionDao _subscriptionDao;

    public SubscriptionService(
        ILogger<SubscriptionService> logger,
        ISubscriptionDao subscriptionDao
        )
    {
        _logger = logger;
        _subscriptionDao = subscriptionDao;
    }

    public async Task<bool> SaveAsync(string userId, SubscriptionItem request, CancellationToken cancellationToken = default)
    {
        var response = await _subscriptionDao.SaveAsync(request, cancellationToken);
        return response;
    }

}
