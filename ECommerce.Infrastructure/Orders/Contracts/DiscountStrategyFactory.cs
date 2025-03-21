namespace ECommerce.Infrastructure.Orders.Contracts;

using ECommerce.Infrastructure.Orders.Enums;
using Enums;
using Strategies;
using Strategies.Discount;

public static class DiscountStrategyFactory
{
    public static IDiscountStrategy CreateDiscountStrategy(DiscountType type, decimal value)
    {
        switch (type)
        {
            case DiscountType.PercentageDiscount:
                return new PercentageDiscountStrategy(value);
            case DiscountType.AmountDiscount:
                return new AmountDiscountStrategy(value);
            default:
                return null;
        }
    }
}
