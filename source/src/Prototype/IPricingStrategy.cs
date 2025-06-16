using DesignPatterns.Strategy;

namespace DesignPatterns.Prototype
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice(decimal basePrice);
        IPricingStrategy Clone();
    }
}
