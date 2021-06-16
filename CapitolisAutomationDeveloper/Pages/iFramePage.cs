using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisAutomationDeveloper.Pages
{
    public class iFramePage : DriverHelper
    {
        IWebElement iFrame => Driver.FindElement(By.XPath("//*[@id= 'mce_0_ifr']"));
        IWebElement txtBox => Driver.FindElement(By.Id("tinymce"));
        public void WriteTextInFrame(string txt)
        {
            //Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//*[@id= 'mce_0_ifr']")));
            Driver.SwitchTo().Frame(iFrame);
            txtBox.Clear();
            txtBox.SendKeys(txt);
           // Driver.FindElement(By.Id("tinymce")).Clear();
            //Driver.FindElement(By.Id("tinymce")).SendKeys(txt);

        }

        public string getTextFromtxtBox()
        {
            return txtBox.Text;
        }
    }
}
