using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisAutomationDeveloper.Pages
{
    public class AuthPage : DriverHelper
    {
        IWebElement authTxt => Driver.FindElement(By.XPath("//*[@class='example']"));

        public string getAuthText() => authTxt.Text;

    }
}
