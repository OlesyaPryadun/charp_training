using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace addressbook_web_tests
{
    public class BaseHelper
    {
        protected IWebDriver driver;
        protected ApplicationManager manager;
         
        public BaseHelper(ApplicationManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver;
        }

        public void Type(By locator, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator).SendKeys(text);
            }
           else
           {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
           }

        }

        public void Click(By locator)
        {

            driver.FindElement(locator).Click();

        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}