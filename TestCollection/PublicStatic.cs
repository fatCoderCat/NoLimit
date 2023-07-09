namespace TestCollection;

public static class PublicStatic
{
    public static string _publicStaticField = nameof(_publicStaticField);
    internal static string _internalStaticField = nameof(_internalStaticField);
    private static string _privateStaticField = "_privateStaticField";

    public const string _publicStaticConstField = nameof(_publicStaticConstField);
    internal const string _internalStaticConstField = nameof(_internalStaticConstField);
    private const string _privateStaticConstField = "_privateStaticConstField";

    public static readonly string _publicStaticReadOnlyField = nameof(_publicStaticReadOnlyField);
    internal static readonly string _internalStaticReadOnlyField = nameof(_internalStaticReadOnlyField);
    private static readonly string _privateStaticReadOnlyField = "_privateStaticReadOnlyField";
}