using StrategyChallenge.Entity;
using StrategyChallenge.Strategy;

namespace StrategyChallenge.ConcreteStrategy;
public class Fedex : IShippingCalculatorStrategy
{
    private readonly decimal _baseCost = 30.00m;
    private readonly decimal _perKgCost = 5.00m;
    private readonly decimal _expressChargeMultiplier = 1.80m;
    private readonly decimal _remoteAreaCharge = 20.00m;
    private readonly int _usualDeliveryTime = 5;
    private readonly int _expressDeliveryTime = 2;
    private readonly decimal _maxWeight = 50.00m;

    public decimal CalculateShipping(ShippingInfo info, string carrier)
    {
        decimal cost = _baseCost + (info.Weight * _perKgCost);

        if (info.IsExpress)
            cost *= _expressChargeMultiplier;

        if (info.Destination.Contains("Norte") || info.Destination.Contains("Nordeste"))
            cost += _remoteAreaCharge;

        Console.WriteLine($"→ Cálculo FedEx: R$ {cost:N2}");
        return cost;
    }

    public int GetDeliveryTime(ShippingInfo info, string carrier)
    {
        return info.IsExpress ? _expressDeliveryTime : _usualDeliveryTime;
    }

    public bool IsAvailable(ShippingInfo info, string carrier)
    {
        return info.Weight <= _maxWeight;
    }
}
