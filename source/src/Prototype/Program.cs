using System;
using System.Collections.Generic;
namespace DesignPatterns.Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ursprünglicher Sale
            var baseSale = new Sale
            {
                PricingStrategy = new FixedDiscountStrategy(10m),
                Customer = "Max Mustermann"
            };
            baseSale.Items.Add("Artikel 1");

            // Klon des ursprünglichen Sale
            var newSale = (Sale)baseSale.Clone();
            newSale.Items.Add("Artikel 2");

            Console.WriteLine("Base Sale Artikel: " + string.Join(", ", baseSale.Items));
            Console.WriteLine("New Sale Artikel: " + string.Join(", ", newSale.Items));

            Console.WriteLine("Base Preis: " + baseSale.GetFinalPrice(100));
            Console.WriteLine("New Preis: " + newSale.GetFinalPrice(200));
        }
    }
}
