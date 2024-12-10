using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V128.DeviceAccess;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;


namespace SS_Console
{
    public class PrintXeroxModel
    {
        
        public IWebElement PrintXeroxNavigation() {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            ChromeDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("http://192.168.29.80");
            IWebElement ClickAdvanced = driver.FindElement(By.Id("details-button"));
            ClickAdvanced.Click();
            IWebElement ClickProceed = driver.FindElement(By.Id("proceed-link"));
            ClickProceed.Click();
            IWebElement iFrame = driver.FindElement(By.Name("wlmframe"));
            driver.SwitchTo().Frame(iFrame);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => driver.FindElement(By.XPath("//*[@id=\"tm2\"]")).Displayed);
            IWebElement DivClick = driver.FindElement(By.XPath("//*[@id=\"tm2\"]"));
            DivClick.Click();
            wait.Until(d => driver.FindElement(By.XPath("//*[@id=\"s81\"]")).Displayed);
            IWebElement CounterClick = driver.FindElement(By.XPath("//*[@id=\"s81\"]"));
            CounterClick.Click();
            IWebElement Cframe = driver.FindElement(By.Name("deviceconfig"));
            driver.SwitchTo().Frame(Cframe);
            IWebElement TableContent = driver.FindElement(By.Id("contentrow"));
            //driver.Close();
            return TableContent;

        }
        public void PrintXeroxByFunction(IWebElement Content) {
          
        IList<IWebElement> TableRows = Content.FindElements(By.TagName("td"));
        foreach (IWebElement tableRow in TableRows)
            {
                Console.WriteLine(tableRow.Text);
            }
        }
        public void PrintXeroxByPapersize(IWebElement Content)
        {
            IWebElement SelectOption = (IWebElement)Content.FindElements(By.Id("addrType"));
            SelectOption.Click();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
           //wait.Until(d => driver.FindElement(By.XPath("//*[@id=\"tm2\"]")).Displayed);


            IList<IWebElement> TableRows = Content.FindElements(By.TagName("td"));
            foreach (IWebElement tableRow in TableRows)
            {
                Console.WriteLine(tableRow.Text);
            }
        }
        public void PrintXeroxByPaperSaving(IWebElement Content)
        {
            IList<IWebElement> TableRows = Content.FindElements(By.TagName("td"));
            foreach (IWebElement tableRow in TableRows)
            {
                Console.WriteLine(tableRow.Text);
            }
        }
        public void ScanningData(IWebElement Content)
        {

        }


    }
}
