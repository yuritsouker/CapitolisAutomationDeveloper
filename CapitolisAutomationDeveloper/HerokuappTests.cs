using CapitolisAutomationDeveloper.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CapitolisAutomationDeveloper
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            //Driver = new ChromeDriver(@"C:\chromedriver_win32");
            ChromeOptions option = new ChromeOptions();
            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver(option);
        }

        [Test]
        public void CheckBoxTest()
        {
            HerokuHomePage herokuHomePage = new HerokuHomePage();

            herokuHomePage.NavigateToHeroku();

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Assert.Pass();
        }
    }
}