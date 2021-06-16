using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace CapitolisAutomationDeveloper
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(@"C:\chromedriver_win32");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Assert.Pass();
        }
    }
}