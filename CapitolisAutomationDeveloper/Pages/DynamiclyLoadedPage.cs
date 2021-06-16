using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisAutomationDeveloper.Pages
{
    public class DynamiclyLoadedPage : DriverHelper
    {
        IWebElement btnStart => Driver.FindElement(By.XPath("//button[contains(.,'Start')]"));

        public string GetTextFromDynamiclyLoadedPage()
        {

            btnStart.Click();
            WebDriverWait w = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            w.Until(ExpectedConditions.ElementExists(By.Id("finish")));
            IWebElement textTitle = Driver.FindElement(By.Id("finish"));
            return textTitle.Text;

        }
    }
}
