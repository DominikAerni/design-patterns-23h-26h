namespace DesignPatterns.Prototype
{
    public class FixedDiscountStrategy : IPricingStrategy
    {
        private readonly decimal _discountAmount;

        public FixedDiscountStrategy(decimal discountAmount)
        {
            _discountAmount = discountAmount;
        }

        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice - _discountAmount;
        }

        public IPricingStrategy Clone()
        {
            return new FixedDiscountStrategy(_discountAmount);
        }
    }
}
