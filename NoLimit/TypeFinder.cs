using System.Reflection;
using System.Text.RegularExpressions;

namespace NoLimit;

public static class TypeFinder
{
    // If you want to find nested class - specify full name, but without namespaces
    public static Type FindType(this Assembly assembly, string name)
    {
        //For nested classes we need to use '+' in name instead of '.'
        var regex = new Regex($@"(?:\.|^)({name.Replace(".", @"\+")})(?=$|\n)");
        var types = assembly.GetTypes().Where(x => regex.IsMatch(x.FullName)).ToList();

        if (!types.Any())
            throw new Exception($"Type with name '{name}' is not found. Assembly: '{assembly.FullName}'");

        if (types.Count > 1)
        {
            var typeNames = string.Join(" ,", types.Select(x => $"'{x.FullName}'"));
            throw new Exception(
                $"There are multiple types with the name '{name}' in assembly '{assembly.FullName}' found: {typeNames}");
        }

        return types.First();
    }
}