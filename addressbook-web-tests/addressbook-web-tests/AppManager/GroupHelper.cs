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
    public class GroupHelper : BaseHelper
    {
        
        public GroupHelper(ApplicationManager manager)
            : base(manager)
        {         
        }



        public GroupHelper Create(GroupData group)
        {
            manager.NavigationHelper.OpenGroupsPage();

            InitGroupCreation();
            FillInGroupForm(group);
            SubmiGroupCreation();
            ReturnToGroupPage();

            return this;
        }

        public GroupHelper Remove(int v)
        {
            manager.NavigationHelper.OpenGroupsPage();
            manager.GroupHelper
                .SelectGroup(1)
                .RemoveGroup()
                .ReturnToGroupPage();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();

            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='new'])[2]")).Click();

            return this;
        }

        public GroupHelper FillInGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);

            return this;
        }

        public GroupHelper SubmiGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();

            return this;
        }

        public GroupHelper ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();

            return this;
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();

            return this;
        }
    }
}
