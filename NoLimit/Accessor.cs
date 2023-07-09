using System.Reflection;

namespace NoLimit;

public static class Accessor
{
    public static bool SetStaticField<T>(this Type type, string fieldName, T fieldValue)
    {
        try
        {
            var prop = type.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);
            if (null != prop)
            {
                prop.SetValue(null, fieldValue);
                return true;
            }
        }
        catch
        {
        }
        
        return false;
    }
    
    public static T GetStaticField<T>(this Type type, string fieldName)
    {
        var prop = type.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);
        if (prop == null)
        {
            throw new Exception();
        }
        
        return (T)prop.GetValue(null);
    }
}