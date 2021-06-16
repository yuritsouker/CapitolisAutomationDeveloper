using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisAutomationDeveloper.Pages
{
    public class HerokuHomePage : DriverHelper
    {
        public static String URL = "https://the-internet.herokuapp.com/";

        IWebElement lnkCheckBox => Driver.FindElement(By.LinkText("Checkboxes"));

        IWebElement lnkFrames => Driver.FindElement(By.LinkText("Frames"));

        IWebElement lnkiFrame => Driver.FindElement(By.LinkText("iFrame"));

        public void NavigateToHeroku() => Driver.Navigate().GoToUrl(URL);

        public void ClickCheckBoxes() => lnkCheckBox.Click();

        public void CloseBrowser() => Driver.Close();

        public void NavigateToiFrame()
        {
            lnkFrames.Click();
            lnkiFrame.Click();

        }




    }
}
