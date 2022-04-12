using NUnit.Framework;

namespace TechnicalTestMZPSolutions;

public class Tests : BaseTest
{

    [Test]
    public void Test1()
    {
        driver.Navigate().GoToUrl("Google.com");
        Assert.Pass();
    }
}