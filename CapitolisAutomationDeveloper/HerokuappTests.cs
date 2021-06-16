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
            ChromeOptions option = new ChromeOptions();
            new DriverManager().SetUpDriver(new ChromeConfig());
            log.Info("Start Chrome Driver");
            Driver = new ChromeDriver(option);
        }

        [Test]
        public void CheckBoxTest()
        {
            HerokuHomePage herokuHomePage = new HerokuHomePage();

            CheckBoxPage checkBoxPage = new CheckBoxPage();

            log.Info("Open Home Page");

            herokuHomePage.NavigateToHeroku();

            log.Info("Open CheckBoxes Page");

            herokuHomePage.ClickCheckBoxes();

            log.Info("Validate check box status before first click");

            bool checkBox1Status = checkBoxPage.GetCheckBox1Status();
            bool checkBox2Status = checkBoxPage.GetCheckBox2Status();

            log.Debug("Click check boxes");

            checkBoxPage.ClickCheckBox1();
            checkBoxPage.ClickCheckBox2();

            bool checkBox1StatusAfterCkick = checkBoxPage.GetCheckBox1Status();
            bool checkBox2StatusAfterCkick = checkBoxPage.GetCheckBox2Status();

            log.Debug("Test CheckBox Status");
            Assert.AreNotEqual(checkBox1Status, checkBox1StatusAfterCkick);
            Assert.AreNotEqual(checkBox2Status, checkBox2StatusAfterCkick);

            checkBoxPage.ClickCheckBox1();
            checkBoxPage.ClickCheckBox2();

            checkBox1StatusAfterCkick = checkBoxPage.GetCheckBox1Status();
            checkBox2StatusAfterCkick = checkBoxPage.GetCheckBox2Status();

            log.Debug("Test CheckBox after second click");
            Assert.AreEqual(checkBox1Status, checkBox1StatusAfterCkick);
            Assert.AreEqual(checkBox2Status, checkBox2StatusAfterCkick);

            log.Debug("Close Browser");
            herokuHomePage.CloseBrowser();
                        
        }

        [Test]
        public void IFrameTest()
        {
            HerokuHomePage herokuHomePage = new HerokuHomePage();

            iFramePage iFramePage = new iFramePage();

            log.Info("Navigate To Heroku page");

            herokuHomePage.NavigateToHeroku();

            log.Info("Navigate To iFrame page");

            herokuHomePage.NavigateToiFrame();

            log.Info("Write text To iFrame");

            iFramePage.WriteTextInFrame("Yuri Tsouker");

            log.Info("Validate inserted text to iFrame");

            Assert.AreEqual(iFramePage.getTextFromtxtBox(), "Yuri Tsouker");

            herokuHomePage.CloseBrowser();

        }

        [Test]
        public void DynamicLoadingPageTest()
        {
            HerokuHomePage herokuHomePage = new HerokuHomePage();

            DynamiclyLoadedPage dynamiclyLoadedPage = new DynamiclyLoadedPage();

            log.Info("Navigate To Heroku page");

            herokuHomePage.NavigateToHeroku();

            log.Info("Navigate To ToElementRender page");

            herokuHomePage.NavigateToElementRender();

            log.Info("Get Text From Dynamicly Loaded Page");

            string txt = dynamiclyLoadedPage.GetTextFromDynamiclyLoadedPage();

            Assert.That(txt.Contains("Hello World!"), Is.True, "Hello World! text does not appear");

            herokuHomePage.CloseBrowser();

        }


    }
}