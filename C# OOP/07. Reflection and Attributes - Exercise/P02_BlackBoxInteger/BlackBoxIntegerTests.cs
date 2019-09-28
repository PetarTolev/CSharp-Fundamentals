using System.Linq;
using System.Reflection;

namespace P02_BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type classType = typeof(BlackBoxInteger);

            var instance = (BlackBoxInteger) Activator
                .CreateInstance(classType, true);

            while (true)
            {
                string[] inputLine = Console.ReadLine()
                    .Split('_');
                string command = inputLine[0];

                if (command == "END")
                {
                    break;
                }

                int value = int.Parse(inputLine[1]);

                classType.GetMethod(command, BindingFlags.Instance |
                                             BindingFlags.NonPublic)
                    .Invoke(instance, new object[] {value});

                var innerValue = classType
                    .GetField("innerValue", BindingFlags.Instance |
                                            BindingFlags.NonPublic)
                    .GetValue(instance);

                Console.WriteLine(innerValue);
            }
        }
    }
}
