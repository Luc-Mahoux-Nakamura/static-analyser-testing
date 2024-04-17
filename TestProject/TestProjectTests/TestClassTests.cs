using Xunit;

public class TestClassTests
{
    [Fact]
    public void TestMethod_ShouldDoSomething()
    {
        // Arrange
        TestClass testClass = new TestClass();

        // Act
        testClass.TestMethod();

        // Assert
        // Add your assertions here
    }

    [Fact]
    public void AnotherTestMethod_ShouldDoSomething()
    {
        // Arrange
        TestClass testClass = new TestClass();

        // Act
        testClass.AnotherTestMethod();

        // Assert
        // Add your assertions here
    }
}