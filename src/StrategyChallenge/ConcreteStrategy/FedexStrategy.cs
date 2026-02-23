using StrategyChallenge.Entity;
using StrategyChallenge.Strategy;

namespace StrategyChallenge.ConcreteStrategy;
public class FedexStrategy : IShippingCalculatorStrategy
{
    private readonly decimal _baseCost = 30.00m;
    private readonly decimal _perKgCost = 5.00m;
    private readonly decimal _expressChargeMultiplier = 1.80m;
    private readonly decimal _remoteAreaCharge = 20.00m;
    private readonly int _usualDeliveryTime = 5;
    private readonly int _expressDeliveryTime = 2;
    private readonly decimal _maxWeight = 50.00m;

    public decimal CalculateShipping(ShippingInfo info)
    {
        decimal cost = _baseCost + (info.Weight * _perKgCost);

        if (info.IsExpress)
            cost *= _expressChargeMultiplier;

        if (info.Destination.Contains("Norte") || info.Destination.Contains("Nordeste"))
            cost += _remoteAreaCharge;

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
