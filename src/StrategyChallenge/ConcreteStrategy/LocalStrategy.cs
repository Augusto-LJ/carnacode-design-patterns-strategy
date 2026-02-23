using StrategyChallenge.Entity;
using StrategyChallenge.Strategy;

namespace StrategyChallenge.ConcreteStrategy;
public class LocalStrategy : IShippingCalculatorStrategy
{
    private readonly decimal _baseCost = 8.00m;
    private readonly decimal _perKgCost = 1.50m;
    private readonly int _deliveryTime = 1;
    private readonly string _serviceArea = "São Paulo-SP";
    public decimal CalculateShipping(ShippingInfo info)
    {
        decimal cost = _baseCost + (info.Weight * _perKgCost);

        if (!info.Destination.Contains(_serviceArea))
        {
            Console.WriteLine("   ❌ Não atende esta região!");
            return 0;
        }

        return cost;
    }

    public int GetDeliveryTime(ShippingInfo info)
    {
        return _deliveryTime;
    }

    public bool IsAvailable(ShippingInfo info)
    {
        return info.Destination.Contains(_serviceArea);
    }
}
