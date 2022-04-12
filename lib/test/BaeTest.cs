using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TechnicalTestMZPSolutions;

public class BaseTest
{
    public IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        driver = new ChromeDriver();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Close();
    }
}