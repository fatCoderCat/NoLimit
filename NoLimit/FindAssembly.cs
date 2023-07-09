using System.Reflection;

namespace NoLimit;

public static class FindAssembly
{
    public static Assembly ByShortName(string name)
    {
        Assembly.Load(new AssemblyName(name));
        
        var assemblyName = name + ", ";
        var assemblies = AppDomain.CurrentDomain.GetAssemblies()
            .Where(x => x.FullName.Contains(assemblyName)).ToList();

        if (!assemblies.Any())
        {
            throw new Exception(
                $"Assembly with a short name '{name}' is not found. Check you referenced assembly in your project.");
        }
        
        if(assemblies.Count > 1)
        {
            var assemblyNames = string.Join(", ", assemblies.Select(x => $"'{x.FullName}\n'"));
            throw new Exception(
                $"You search assembly with a name '{name}', but there are multiple assemblies with such name found: {assemblyNames}. Try to search using full assembly name.");
        }

        return assemblies.First();
    }
    
    public static Assembly ByFullName(string name)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies()
            .Where(x => x.FullName == name).ToList();

        if (!assemblies.Any())
        {
            throw new Exception(
                $"Assembly with a short name '{name}' is not found. Check you referenced assembly in your project.");
        }
        
        if(assemblies.Count > 1)
        {
            var assemblyNames = string.Join(", ", assemblies.Select(x => $"'{x.FullName}'"));
            throw new Exception(
                $"You search assembly with a name '{name}', but there are multiple assemblies with such name found: {assemblyNames}.");
        }

        return assemblies.First();
    }
}