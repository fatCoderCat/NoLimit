using NoLimit;

namespace UnitTests;

[TestFixture]
public class InternalStaticClassTests
{
    private Type _type;
    
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _type = FindAssembly.ByShortName("TestCollection").FindType("InternalStatic");
    }

    [Test]
    public void GetStaticField_PrivateStaticField()
    {
        // Act
        var result = _type.GetStaticField<string>("_privateStaticField");
        
        // Assert
        Assert.That(result, Is.EqualTo("_privateStaticField"));
    }
    
    [Test]
    public void SetStaticField_PrivateStaticField()
    {
        // Arrange 
        var valueToAssign = Guid.NewGuid().ToString();
        
        // Act
        var result = _type.SetStaticField("_privateStaticField", valueToAssign);
        
        // Assert
        var value = _type.GetStaticField<string>("_privateStaticField");
        Assert.IsTrue(result);
        Assert.That(value, Is.EqualTo(valueToAssign));
    }
    
    [Test]
    public void GetStaticField_InternalStaticField()
    {
        // Act
        var result = _type.GetStaticField<string>("_internalStaticField");
        
        // Assert
        Assert.That(result, Is.EqualTo("_internalStaticField"));
    }
    
    [Test]
    public void SetStaticField_InternalStaticField()
    {
        // Arrange
        var valueToAssign = Guid.NewGuid().ToString();

        // Act
        var result = _type.SetStaticField("_internalStaticField", valueToAssign);
        
        // Arrange
        var value = _type.GetStaticField<string>("_internalStaticField");
        Assert.IsTrue(result);
        Assert.That(value, Is.EqualTo(valueToAssign));
    }
    
    [Test]
    public void GetStaticField_PublicStaticField()
    {
        // Act
        var result = _type.GetStaticField<string>("_publicStaticField");
        
        // Assert
        Assert.That(result, Is.EqualTo("_publicStaticField"));
    }
    
    [Test]
    public void SetStaticField_PublicStaticField()
    {
        // Arrange
        var valueToAssign = Guid.NewGuid().ToString();
        
        // Act
        var result = _type.SetStaticField("_publicStaticField", valueToAssign);
        
        // Assert
        var value = _type.GetStaticField<string>("_publicStaticField");
        Assert.IsTrue(result);
        Assert.That(value, Is.EqualTo(valueToAssign));
    }
    
    [Test]
    public void GetStaticField_PrivateReadOnlyStaticField()
    {
        // Act
        var value = _type.GetStaticField<string>("_privateStaticReadOnlyField");
        
        // Assert
        Assert.That(value, Is.EqualTo("_privateStaticReadOnlyField"));
    }
    
    [Test]
    public void SetStaticField_PrivateReadOnlyStaticField()
    {
        // Arrange
        var valueToAssign = Guid.NewGuid().ToString();
        
        // Act
        var result = _type.SetStaticField("_privateStaticReadOnlyField", valueToAssign);
        
        // Arrange
        var value = _type.GetStaticField<string>("_privateStaticReadOnlyField");
        Assert.IsFalse(result);
        Assert.That(value, Is.EqualTo("_privateStaticReadOnlyField"));
    }
    
    [Test]
    public void GetStaticField_PublicReadOnlyStaticField()
    {
        // Act
        var value = _type.GetStaticField<string>("_publicStaticReadOnlyField");
        
        // Assert
        Assert.That(value, Is.EqualTo("_publicStaticReadOnlyField"));
    }
    
    [Test]
    public void SetStaticField_PublicReadOnlyStaticField()
    {
        // Arrange
        var valueToAssign = Guid.NewGuid().ToString();
        
        // Act
        var result = _type.SetStaticField("_publicStaticReadOnlyField", valueToAssign);
        
        // Arrange
        var value = _type.GetStaticField<string>("_publicStaticReadOnlyField");
        Assert.IsFalse(result);
        Assert.That(value, Is.EqualTo("_publicStaticReadOnlyField"));
    }
    
    [Test]
    public void GetStaticField_InternalReadOnlyStaticField()
    {
        // Act
        var value = _type.GetStaticField<string>("_internalStaticReadOnlyField");
        
        // Assert
        Assert.That(value, Is.EqualTo("_internalStaticReadOnlyField"));
    }
    
    [Test]
    public void SetStaticField_InternalReadOnlyStaticField()
    {
        // Arrange
        var valueToAssign = Guid.NewGuid().ToString();
        
        // Act
        var result = _type.SetStaticField("_internalStaticReadOnlyField", valueToAssign);
        
        // Arrange
        var value = _type.GetStaticField<string>("_internalStaticReadOnlyField");
        Assert.IsFalse(result);
        Assert.That(value, Is.EqualTo("_internalStaticReadOnlyField"));
    }
 
    [Test]
    public void GetStaticField_PrivateConstStaticField()
    {
        // Act
        var value = _type.GetStaticField<string>("_privateStaticConstField");
        
        // Assert
        Assert.That(value, Is.EqualTo("_privateStaticConstField"));
    }
    
    [Test]
    public void SetStaticField_PrivateConstStaticField()
    {
        // Arrange
        var valueToAssign = Guid.NewGuid().ToString();
        
        // Act
        var result = _type.SetStaticField("_privateStaticConstField", valueToAssign);
        
        // Arrange
        var value = _type.GetStaticField<string>("_privateStaticConstField");
        Assert.IsFalse(result);
        Assert.That(value, Is.EqualTo("_privateStaticConstField"));
    }
    
    [Test]
    public void GetStaticField_PublicConstStaticField()
    {
        // Act
        var value = _type.GetStaticField<string>("_publicStaticConstField");
        
        // Assert
        Assert.That(value, Is.EqualTo("_publicStaticConstField"));
    }
    
    [Test]
    public void SetStaticField_PublicConstStaticField()
    {
        // Arrange
        var valueToAssign = Guid.NewGuid().ToString();
        
        // Act
        var result = _type.SetStaticField("_publicStaticConstField", valueToAssign);
        
        // Arrange
        var value = _type.GetStaticField<string>("_publicStaticConstField");
        Assert.IsFalse(result);
        Assert.That(value, Is.EqualTo("_publicStaticConstField"));
    }
    
    [Test]
    public void GetStaticField_InternalConstStaticField()
    {
        // Act
        var value = _type.GetStaticField<string>("_internalStaticConstField");
        
        // Assert
        Assert.That(value, Is.EqualTo("_internalStaticConstField"));
    }
    
    [Test]
    public void SetStaticField_InternalConstStaticField()
    {
        // Arrange
        var valueToAssign = Guid.NewGuid().ToString();
        
        // Act
        var result = _type.SetStaticField("_internalStaticConstField", valueToAssign);
        
        // Arrange
        var value = _type.GetStaticField<string>("_internalStaticConstField");
        Assert.IsFalse(result);
        Assert.That(value, Is.EqualTo("_internalStaticConstField"));
    }
    
    [Test]
    public void SetStaticField_SetNullToNonNullable()
    {
        // Act
        var result = _type.SetStaticField("_privateStaticField", (string)null!);
        
        // Assert
        var value = _type.GetStaticField<string>("_privateStaticField");
        Assert.IsTrue(result);
        Assert.IsNull(value);
    }
}