using DesignPatterns.Prototype;

namespace DesignPatterns.Tests.Prototype
{
    public class PrototypeTests
    {
        [Fact]
        public void Clone_ShouldCreateExactCopyOfSale()
        {
            // Arrange
            var original = new Sale
            {
                Customer = "Max Mustermann",
                PricingStrategy = new FixedDiscountStrategy(10m),
                Items = new List<string> { "Artikel 1" }
            };

            // Act
            var clone = (Sale)original.Clone();

            // Assert
            Assert.Equal(original.Customer, clone.Customer);
            Assert.Equal(original.Items, clone.Items);
            Assert.NotSame(original.Items, clone.Items);
            Assert.NotSame(original, clone);
        }

        [Fact]
        public void Clone_ShouldAllowIndependentModification()
        {
            // Arrange
            var original = new Sale
            {
                Customer = "Anna",
                PricingStrategy = new FixedDiscountStrategy(5m),
                Items = new List<string> { "Artikel A" }
            };

            // Act
            var clone = (Sale)original.Clone();
            clone.Items.Add("Artikel B");

            // Assert
            Assert.Single(original.Items);
            Assert.Equal(2, clone.Items.Count);
        }

        [Fact]
        public void GetFinalPrice_ShouldReturnSameResultForClone()
        {
            // Arrange
            var original = new Sale
            {
                PricingStrategy = new FixedDiscountStrategy(15m)
            };
            var clone = (Sale)original.Clone();

            // Act
            var originalPrice = original.GetFinalPrice(100);
            var clonePrice = clone.GetFinalPrice(100);

            // Assert
            Assert.Equal(originalPrice, clonePrice);
        }
    }
}
