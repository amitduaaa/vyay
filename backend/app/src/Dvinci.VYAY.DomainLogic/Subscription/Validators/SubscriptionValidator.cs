using Dvinci.VYAY.DataModel.Subscription;
using FluentValidation;

namespace Dvinci.VYAY.DomainLogic.Subscription.Validators;

public class SubscriptionValidator : AbstractValidator<SubscriptionItem>
{
    public SubscriptionValidator()
    {
        RuleFor(x => x).NotNull().NotEmpty().WithMessage("SUBSCRIPTION.ERRORS.REQUEST_EMPTY");

        When(x => x != null, () =>
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("SUBSCRIPTION.ERRORS.NAME_NULL");
            RuleFor(x => x.Url).NotNull().NotEmpty().WithMessage("SUBSCRIPTION.ERRORS.URL_NULL");
            RuleFor(x => x.Price).NotNull().NotEmpty().WithMessage("SUBSCRIPTION.ERRORS.PRICE_NULL");
            RuleFor(x => x.Cycle).NotNull().NotEmpty().WithMessage("SUBSCRIPTION.ERRORS.CYCLE_NULL");
            RuleFor(x => x.Category).NotNull().NotEmpty().WithMessage("SUBSCRIPTION.ERRORS.CATEGORIES_NULL");
            RuleFor(x => x.Notes).NotNull().NotEmpty().WithMessage("SUBSCRIPTION.ERRORS.NOTES_NULL");
            RuleFor(x => x.Date).NotNull().NotEmpty().WithMessage("SUBSCRIPTION.ERRORS.DATE_NULL");
        });
    }
}
