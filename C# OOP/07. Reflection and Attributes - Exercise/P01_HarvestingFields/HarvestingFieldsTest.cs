namespace P01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type classType = Type.GetType("P01_HarvestingFields.HarvestingFields");

            List<FieldInfo> fields = new List<FieldInfo>();

            while (true)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "private":
                        fields = classType
                            .GetFields(BindingFlags.NonPublic |
                                       BindingFlags.Instance)
                            .Where(f => f.IsPrivate)
                            .ToList();
                        break;
                    case "protected":
                        fields = classType
                            .GetFields(BindingFlags.Instance |
                                       BindingFlags.NonPublic)
                            .Where(f => f.IsFamily)
                            .ToList();
                        break;
                    case "public":
                        fields = classType
                            .GetFields(BindingFlags.Instance |
                                       BindingFlags.Public)
                            .ToList();
                        break;
                    case "all":
                        fields = classType
                            .GetFields(BindingFlags.Public |
                                       BindingFlags.NonPublic |
                                       BindingFlags.Static |
                                       BindingFlags.Instance)
                            .ToList();
                        break;
                    case "HARVEST":
                        return;
                }

                foreach (var field in fields)
                {

                    string accessModifier =
                        field.IsPublic
                            ? "public"
                            : field.IsPrivate
                                ? "private"
                                : "protected";

                    Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}
