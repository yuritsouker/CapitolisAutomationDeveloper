using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CapitolisAutomationDeveloper.Pages
{
    public class ExcelPage : DriverHelper
    {
        IWebElement enabledLink => Driver.FindElement(By.XPath("//a[contains(.,'Enabled')]"));

        public void clickDownloadExcel()
        {
            //Click first menu 
            enabledLink.Click();
            
            Actions action = new Actions(Driver);
            WebDriverWait w = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));

            //Wait till second menu will appear
            w.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(.,'Downloads')]")));

            action.MoveToElement(Driver.FindElement(By.XPath("//a[contains(.,'Downloads')]"))).Build().Perform(); ;

            //Wait till element will be clickable
            w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(.,'Downloads')]"))).Click();

            IWebElement downloadLink = Driver.FindElement(By.XPath("//a[contains(.,'Downloads')]"));

            downloadLink.Click();

            WebDriverWait y = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            y.Until(ExpectedConditions.ElementExists(By.XPath("//a[contains(.,'Excel')]")));

            IWebElement excelLink = Driver.FindElement(By.XPath("//a[contains(.,'Excel')]"));

            excelLink.Click();

        }

        public String getData(int row, int col ,string file)
        {
            using (var package = new ExcelPackage(new FileInfo(file)))
            {
                ExcelWorksheet worksSheet = package.Workbook.Worksheets["Sheet 1 - Table 1"];
                string value = worksSheet.Cells[row, col].Value.ToString();
                return value;

            }
        }

    }
}
