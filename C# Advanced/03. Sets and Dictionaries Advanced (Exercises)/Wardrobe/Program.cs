namespace Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
 
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                List<string> items = input[1].Split(",").ToList();

                if (wardrobe.ContainsKey(color))
                {
                    foreach (var item in items)
                    {
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
                else
                {
                    Dictionary<string, int> itemAndQuantity = new Dictionary<string, int>();

                    foreach (var item in items)
                    {
                        if (itemAndQuantity.ContainsKey(item))
                        {
                            itemAndQuantity[item]++;
                        }
                        else
                        {
                            itemAndQuantity.Add(item, 1);
                        }
                    }

                    wardrobe.Add(color, itemAndQuantity);
                }
            }

            string[] productForSearching = Console.ReadLine().Split();
            string colorForSearching = productForSearching[0];
            string product = productForSearching[1];

            foreach (var kvp in wardrobe)
            {
                string color = kvp.Key;
                Dictionary<string, int> products = kvp.Value;

                Console.WriteLine($"{color} clothes:");

                foreach (var prod in products)
                {
                    if (color == colorForSearching && product == prod.Key)
                    {
                        Console.WriteLine($"* {prod.Key} - {prod.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {prod.Key} - {prod.Value}");
                    }
                }
            }
        }
    }
}
 