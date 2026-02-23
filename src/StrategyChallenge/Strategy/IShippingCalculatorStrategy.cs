using StrategyChallenge.Entity;

namespace StrategyChallenge.Strategy;
public interface IShippingCalculatorStrategy
{
    decimal CalculateShipping(ShippingInfo info);
    int GetDeliveryTime(ShippingInfo info);
    bool IsAvailable(ShippingInfo info);
}
