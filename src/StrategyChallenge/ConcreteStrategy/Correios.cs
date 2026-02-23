using StrategyChallenge.Entity;
using StrategyChallenge.Strategy;

namespace StrategyChallenge.ConcreteStrategy;
public class Correios : IShippingCalculatorStrategy
{
    private readonly decimal _baseCost = 15.00m;
    private readonly decimal _perKgCost = 2.50m;
    private readonly decimal _expressCharge = 25.00m;
    private readonly decimal _sameStateDiscount = 0.15m;
    private readonly int _usualDeliveryTime = 7;
    private readonly int _expressDeliveryTime = 3;

    public decimal CalculateShipping(ShippingInfo info, string carrier)
    {
        decimal cost = _baseCost + (info.Weight * _perKgCost);

        if (info.IsExpress)
            cost += _expressCharge;

        if (info.Origin.Split('-')[1] == info.Destination.Split('-')[1])
            cost *= (1 - _sameStateDiscount);

        Console.WriteLine($"→ Cálculo Correios: R$ {cost:N2}");
        return cost;
    }

    public int GetDeliveryTime(ShippingInfo info, string carrier)
    {
        return info.IsExpress ? _expressDeliveryTime : _usualDeliveryTime;
    }

    public bool IsAvailable(ShippingInfo info, string carrier)
    {
        return true; // always available
    }
}
