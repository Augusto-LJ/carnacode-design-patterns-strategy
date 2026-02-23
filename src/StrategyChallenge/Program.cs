using StrategyChallenge.ConcreteStrategy;
using StrategyChallenge.Entity;

Console.WriteLine("=== Sistema de Cálculo de Frete ===");

var correiosCalculator = new CorreiosStrategy();
var fedexCalculator = new FedexStrategy();
var dhlCalculator = new DhlStrategy();
var localCalculator = new LocalStrategy();

var shipping1 = new ShippingInfo("São Paulo-SP", "Rio de Janeiro-RJ", 5.0m, false);
var shipping2 = new ShippingInfo("São Paulo-SP", "Manaus-AM", 8.0m, true);
var shipping3 = new ShippingInfo("São Paulo-SP", "São Paulo-SP", 8.0m, true);

// Testando diferentes transportadoras
var correiosCost = correiosCalculator.CalculateShipping(shipping1);
var correiosTime = correiosCalculator.GetDeliveryTime(shipping1);
Console.WriteLine($"Preço dos correios: R${correiosCost:F2}");
Console.WriteLine($"Prazo dos correios: {correiosTime} dias úteis\n");

var fedexCost = fedexCalculator.CalculateShipping(shipping2);
var fedexTime = fedexCalculator.GetDeliveryTime(shipping2);
Console.WriteLine($"Preço do Fedex: R${fedexCost:F2}");
Console.WriteLine($"Prazo do Fedex: {fedexTime} dias úteis\n");

var dhlCost = dhlCalculator.CalculateShipping(shipping3);
var dhlTime = dhlCalculator.GetDeliveryTime(shipping3);
Console.WriteLine($"Preço do Dhl: R${dhlCost:F2}");
Console.WriteLine($"Prazo do Dhl: {dhlTime} dias úteis\n");

var localCost = localCalculator.CalculateShipping(shipping3);
var localTime = localCalculator.GetDeliveryTime(shipping3);
Console.WriteLine($"Preço do local: R${localCost:F2}");
Console.WriteLine($"Prazo do local: {localTime} dias úteis\n");
