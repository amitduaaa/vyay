using Dvinci.VYAY.DataModel.Subscription;
using Dvinci.VYAY.DomainLogic.Subscription;
using Dvinci.VYAY.DomainLogic.Subscription.Validators;
using Dvinci.VYAY.DomainLogic.Utils;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dvinci.VYAY.DomainLogic;

public static class DomainLogicExtension
{
    public static void RegisterDomainLogic(this IServiceCollection services)
    {
        services.AddTransient<IValidatorInterceptor, FluentValidatorInterceptor>();

        // Services
        services.AddSingleton<ISubscriptionService, SubscriptionService>();

        // Validators
        services.AddTransient<IValidator<SubscriptionItem>, SubscriptionValidator>();
    }
}
