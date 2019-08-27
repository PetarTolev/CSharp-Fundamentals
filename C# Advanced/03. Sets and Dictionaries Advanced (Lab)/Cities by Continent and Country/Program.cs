namespace Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var continentData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] continetCountryCity = Console.ReadLine().Split().ToArray();
                string continet = continetCountryCity[0];
                string country = continetCountryCity[1];
                string city = continetCountryCity[2];

                if (continentData.ContainsKey(continet))
                {
                    if (continentData[continet].ContainsKey(country))
                    {
                        continentData[continet][country].Add(city);
                    }
                    else
                    {
                        List<string> cities = new List<string>();
                        cities.Add(city);

                        continentData[continet].Add(country, cities);
                    }
                }
                else
                {
                    List<string> cities = new List<string>();
                    cities.Add(city);

                    Dictionary<string, List<string>> countries = new Dictionary<string, List<string>>(); 
                    countries.Add(country, cities);

                    continentData.Add(continet, countries);
                }
            }

            foreach (var kvpContinent in continentData)
            {
                string continent = kvpContinent.Key;
                Dictionary<string, List<string>> continentAndCountry = kvpContinent.Value;

                Console.WriteLine($"{continent}:");

                foreach (var kvpCountry in continentAndCountry)
                {
                    string country = kvpCountry.Key;
                    List<string> cities = kvpCountry.Value;

                    Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");

                }
            }

        }
    }
}
