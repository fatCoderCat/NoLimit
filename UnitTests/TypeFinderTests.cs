using NoLimit;

namespace UnitTests;

[TestFixture]
public class TypeFinderTests
{
    private System.Reflection.Assembly _assembly = default!;
    
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _assembly = FindAssembly.ByShortName("TestCollection");
    }

    [Test]
    public void FindType_PublicStaticType()
    {
        // Act
        var type = _assembly.FindType("PublicStatic");
        
        // Assert
        Assert.IsNotNull(type);
    }
    
    [Test]
    public void FindType_InternalStaticType()
    {
        // Act
        var type = _assembly.FindType("InternalStatic");
        
        // Assert
        Assert.IsNotNull(type);
    }
    
    [Test]
    public void FindType_NestedStaticTypesByName()
    {
        // Act
        var type = _assembly.FindType("PublicStaticHolder.PrivateStaticTwo");
        
        // Assert
        Assert.IsNotNull(type);
    }
    
    [Test]
    public void FindType_NestedStaticTypesByFullPath()
    {
        // Act
        var type = _assembly.FindType("PublicStaticHolder.PrivateStatic");
        
        // Assert
        Assert.IsNotNull(type);
    }
    
    [Test]
    [Description("Class with name PrivateStatic exists as private nested class inside static class and separate internal static class. In this test we try to search such class by short name.")]
    public void FindType_PrivateStaticNestedAndAlone()
    {
        // Act
        var type = _assembly.FindType("PrivateStatic");
        
        // Assert
        //It finds only separate class but not nested
        Assert.IsNotNull(type);
    }
    
    [Test]
    [Description("Customer can't find nested class by name, they should specify full path, but without namespaces")]
    public void FindType_NestedStaticTypesByShortName()
    {
        // Act / Assert
        Assert.Throws<Exception>(() => _assembly.FindType("PrivateStaticTwo"));
    }
}