
using TestApp;

namespace TestAppUnitTest;

[TestClass]
public class CalculatorUnitTest
{
    [TestMethod("Add two integers")]
    public void AddIntegers()
    {
        Calculator c = new Calculator();
        Assert.AreEqual(2, c.Add(1, 1));
    }
}