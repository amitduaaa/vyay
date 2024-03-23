using Dvinci.VYAY.DataModel.Subscription;
using Dvinci.VYAY.DomainLogic.Subscription;
using FluentValidation;
using Newtonsoft.Json;

namespace Dvinci.VYAY.Backend.Api.Apis;

public class SubscriptionApi : IApi
{
    private readonly ILogger<SubscriptionApi> _logger;
    private readonly ISubscriptionService _subscriptionService;

    public SubscriptionApi(
        ILogger<SubscriptionApi> logger,
        ISubscriptionService subscriptionService
        )
    {
        _logger = logger;
        _subscriptionService = subscriptionService;
    }

    public void Register(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/subscription", AddSubscription);
    }

    public async Task<IResult> AddSubscription(SubscriptionItem request, IValidator<SubscriptionItem> validator, HttpContext httpContext, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation($"SubscriptionApi --> AddSubscription(): Received request with parameters, {JsonConvert.SerializeObject(request)}");

        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (!validationResult.IsValid)
        {
            var dict = validationResult.ToDictionary();
            _logger.LogError($"SubscriptionApi --> AddSubscription(): Model validation failed: {dict}");
            return Results.ValidationProblem(dict);
        }

        var response = await _subscriptionService.SaveAsync("", request, cancellationToken);
        return Results.Ok(response);
    }
}
