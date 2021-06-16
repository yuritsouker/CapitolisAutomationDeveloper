using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisAutomationDeveloper.Pages
{
    public class CheckBoxPage : DriverHelper
    {
        IWebElement checkBox1 => Driver.FindElement(By.XPath("//*[@type ='checkbox'][1]"));

        IWebElement checkBox2 => Driver.FindElement(By.XPath("//*[@type ='checkbox'][2]"));

        public void ClickCheckBox1() => checkBox1.Click();

        public void ClickCheckBox2() => checkBox2.Click();

        public bool GetCheckBox1Status()
        {
            return (checkBox1.Selected);
        }

        public bool GetCheckBox2Status()
        {
            return (checkBox2.Selected);
        }
    }
}
