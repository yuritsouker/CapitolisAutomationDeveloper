using CapitolisAutomationDeveloper.Pages;
using NLog;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CapitolisAutomationDeveloper
{
    public class Tests : DriverHelper
    {
        public Logger log = LogManager.GetCurrentClassLogger();

        [SetUp]
        public void Setup()
        {
            //Driver = new ChromeDriver(@"C:\chromedriver_win32");
            ChromeOptions option = new ChromeOptions();
            new DriverManager().SetUpDriver(new ChromeConfig());
            log.Info("Start Chrome Driver");
            Driver = new ChromeDriver(option);
        }

        [Test]
        public void CheckBoxTest()
        {
            HerokuHomePage herokuHomePage = new HerokuHomePage();

            log.Info("Open Home Page");

            herokuHomePage.NavigateToHeroku();

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Assert.Pass();
        }
    }
}