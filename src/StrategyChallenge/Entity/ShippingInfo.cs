namespace StrategyChallenge.Entity;
public class ShippingInfo(string origin, string destination, decimal weight, bool isExpress)
{
    public string Origin { get; set; } = origin;
    public string Destination { get; set; } = destination;
    public decimal Weight { get; set; } = weight;
    public bool IsExpress { get; set; } = isExpress;
}
