
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    [TestMethod("Subtract two integers")]
    public void SubtractIntegers()
    {
        Calculator c = new Calculator();
        Assert.AreEqual(0, c.Subtract(1, 1));
    }
    [TestMethod("Multiply two integers")]
    public void MultiplyIntegers()
    {
        Calculator c = new Calculator();
        Assert.AreEqual(1, c.Multiply(1, 1));
    }
    [TestMethod("Divide two integers")]
    public void DivideIntegers()
    {
        Calculator c = new Calculator();
        Assert.AreEqual(1, c.Divide(1, 1));
    }
}