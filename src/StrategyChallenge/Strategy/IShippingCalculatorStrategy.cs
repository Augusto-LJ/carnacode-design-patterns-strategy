using StrategyChallenge.Entity;

namespace StrategyChallenge.Strategy;
public interface IShippingCalculatorStrategy
{
    public decimal CalculateShipping(ShippingInfo info, string carrier);
    public int GetDeliveryTime(ShippingInfo info, string carrier);
    public bool IsAvailable(ShippingInfo info, string carrier);
}
