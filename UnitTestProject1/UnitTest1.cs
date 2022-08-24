using NewConsoleApp1;

namespace Testproject1;

[TestClass]
public class Calculator
{
    [TestMethod]
    public void TestAdd()
    {
        Calculator c = new Calculator();
        int result = NewConsoleApp1.Calculator.Add(10, 20);
        Assert.AreEqual(30, result);
    }
}