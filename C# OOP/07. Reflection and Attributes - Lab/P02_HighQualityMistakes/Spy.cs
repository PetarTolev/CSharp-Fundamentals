using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);

        var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        var publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        var nonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder result = new StringBuilder();

        foreach (var field in fields)
        {
            result.AppendLine($"{field.Name} must be private!");
        }

        foreach (var privateMethod in nonPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            result.AppendLine($"{privateMethod.Name} have to be public!");
        }

        foreach (var publicMethod in publicMethods.Where(m => m.Name.StartsWith("set")))
        {
            result.AppendLine($"{publicMethod.Name} have to be private!");
        }

        return result.ToString().TrimEnd();
    }
}