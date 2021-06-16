using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CapitolisAutomationDeveloper.Pages
{
    public class HerokuHomePage : DriverHelper
    {
        public static String URL = "https://the-internet.herokuapp.com/";

        IWebElement lnkCheckBox => Driver.FindElement(By.LinkText("Checkboxes"));

        IWebElement lnkFrames => Driver.FindElement(By.LinkText("Frames"));

        IWebElement lnkiFrame => Driver.FindElement(By.LinkText("iFrame"));

        IWebElement lnkDynamicLoading => Driver.FindElement(By.LinkText("Dynamic Loading"));

        IWebElement lnkExample2 => Driver.FindElement(By.LinkText("Example 2: Element rendered after the fact"));

        IWebElement lnkiJquery => Driver.FindElement(By.LinkText("JQuery UI Menus"));

        IWebElement lnkBasicAuth => Driver.FindElement(By.LinkText("Basic Auth"));

        public void NavigateToHeroku() => Driver.Navigate().GoToUrl(URL);

        public void ClickCheckBoxes() => lnkCheckBox.Click();

        public void CloseBrowser() => Driver.Close();

        public void NavigateToiFrame()
        {
            lnkFrames.Click();
            lnkiFrame.Click();

        }

        public void NavigateToElementRender()
        {
            lnkDynamicLoading.Click();
            lnkExample2.Click();
        }

        public void ClickJQuery() => lnkiJquery.Click();

        public void ClickBasisAuth()
        {
            lnkBasicAuth.Click();
            //Use System.Windows.Forms to send keys - selenium does not work with win form
            SendKeys.Send("admin");
            SendKeys.Send("{TAB}");
            SendKeys.Send("admin");
            SendKeys.Send("{ENTER}");
        }


    }
}
