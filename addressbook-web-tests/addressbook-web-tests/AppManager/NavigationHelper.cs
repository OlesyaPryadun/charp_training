using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class NavigationHelper : BaseHelper
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager
            , string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void OpenLoginPage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        public void OpenHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }

        public NavigationHelper OpenAddContactsPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();

            return this;
        }

        public void OpenGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
