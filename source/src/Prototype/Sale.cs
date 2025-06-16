namespace DesignPatterns.Prototype
{
    public class Sale
    {
        public IPricingStrategy PricingStrategy { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public string Customer { get; set; }

        public decimal GetFinalPrice(decimal basePrice)
        {
            return PricingStrategy.CalculatePrice(basePrice);
        }

        public object Clone()
        {
            return new Sale
        {
            PricingStrategy = this.PricingStrategy.Clone(),
            Items = new List<string>(this.Items),
            Customer = this.Customer
            };
        }
    }
}
