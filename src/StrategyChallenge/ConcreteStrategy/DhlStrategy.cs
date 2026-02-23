using StrategyChallenge.Entity;
using StrategyChallenge.Strategy;

namespace StrategyChallenge.ConcreteStrategy;
public class DhlStrategy : IShippingCalculatorStrategy
{
    private readonly decimal _baseCost = 25.00m;
    private readonly decimal _perKgCost = 4.50m;
    private readonly int _weightThreshold = 10;
    private readonly decimal _extraCostPerKg = 2.00m;
    private readonly decimal _expressCharge = 25.00m;
    private readonly int _usualDeliveryTime = 4;
    private readonly int _expressDeliveryTime = 1;
    private readonly decimal _maxWeight = 50.00m;

    public decimal CalculateShipping(ShippingInfo info)
    {
        decimal cost = _baseCost + (info.Weight * _perKgCost);

        if (info.Weight > _weightThreshold)
            cost += (info.Weight - _weightThreshold) * _extraCostPerKg;

        if (info.IsExpress)
            cost += _expressCharge;

        return cost;
    }

    public int GetDeliveryTime(ShippingInfo info)
    {
        return info.IsExpress ? _expressDeliveryTime : _usualDeliveryTime;
    }

    public bool IsAvailable(ShippingInfo info)
    {
        return info.Weight <= _maxWeight;
    }
}
