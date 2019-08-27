namespace Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }

                string[] inputProps = input.Split(", ").ToArray();
                string shop = inputProps[0];
                string product = inputProps[1];
                double priceOfProduct = double.Parse(inputProps[2]);

                if (shops.ContainsKey(shop))
                {
                    if (shops[shop].ContainsKey(product))
                    {
                        shops[shop][product] = priceOfProduct;
                    }
                    else
                    {
                        shops[shop].Add(product, priceOfProduct);
                    }
                }
                else
                {
                    var productAndPrice = new Dictionary<string, double>();
                    productAndPrice.Add(product, priceOfProduct);

                    shops.Add(shop, productAndPrice);
                }
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                Dictionary<string, double> productAndPriceDict = shop.Value;

                foreach (var kvp in productAndPriceDict)
                {
                    Console.WriteLine($"Product: {kvp.Key}, Price: {kvp.Value}");
                }
            }
        }
    }
}
