namespace FirstService.Tests;

[TestFixture]
public class FirstServiceTests
{
    private FirstService _firstService;

    [SetUp]
    public void Setup()
    {
        _firstService = new FirstService();
    }

    [Test]
    public void IsPrime_InputIs1_ReturnFalse()
    {
       // AAA
       // Arrange
         var candidate = 1;
       // Act
         var calculated_result = _firstService.IsPrime(candidate);  
       // Assert
         Assert.IsFalse(calculated_result);
    }

    [TestCase(-1)]
    [TestCase(0)]
    [TestCase(1)]
    public void IsPrime_InputLessThan2_ReturnFalse(int candidate)
    {
        // Act
         var calculated_result = _firstService.IsPrime(candidate);  
       // Assert
         Assert.IsFalse(calculated_result);

    }

    [Test]
    public void IsPrime_InputIs3_ReturnTrue()
    {
        // Act
         var calculated_result = _firstService.IsPrime(3);  
       // Assert
         Assert.IsTrue(calculated_result);

    }

    [Test]
    public void IsPrime_InputIs100_ReturnFalse()
    {
        // Act
         var calculated_result = _firstService.IsPrime(100);  
       // Assert
         Assert.IsFalse(calculated_result);

    }


}