namespace P11_The_Party_ReservationFilter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();

            List<Filter> filters = new List<Filter>();

            while (true)
            {
                string inputCommandLine = Console.ReadLine();

                if (inputCommandLine == "Print")
                {
                    break;
                }

                string[] tokens = inputCommandLine.Split(";");
                string command = tokens[0];
                string filterType = tokens[1];
                string filterParameter = tokens[2];

                switch (command)
                {
                    case "Add filter":

                        Filter filter = new Filter
                        {
                            FilterType = filterType,
                            FilterParameter = filterParameter
                        };

                        filters.Add(filter);
                        break;
                    case "Remove filter":
                        foreach (var f in filters)
                        {
                            if (f.FilterType == filterType && f.FilterParameter == filterParameter)
                            {
                                int index = filters.IndexOf(f);

                                filters.RemoveAt(index);
                                break;
                            }
                        }   
                        break;
                }
            }

            foreach (var filter in filters)
            {
               input.RemoveAll(GetPredicate(filter));
            }

            Console.WriteLine(string.Join(" ", input));
        }

        public static Predicate<string> GetPredicate(Filter filter)
        {
            Predicate<string> predidcate;

            string filterType = filter.FilterType;
            string filterParameter = filter.FilterParameter;

            switch (filterType)
            {
                case "Starts with": return predidcate = x => x.StartsWith(filterParameter);

                case "Ends with": return predidcate = x => x.EndsWith(filterParameter);

                case "Length": return predidcate = x => x.Length == filterParameter.Length;

                case "Contains": return predidcate = x => x.Contains(filterParameter);
            }

            return null;
        }
    }

    public class Filter
    {
        public string FilterType { get; set; }

        public string FilterParameter { get; set; }
    }
}
