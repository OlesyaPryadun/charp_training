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
    public class ContactHelper : BaseHelper
    {

        public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public ContactHelper Create(ContactData contact)
        {
            manager.NavigationHelper.OpenHomePage();
            InitContactCreation();
            FillInnContactForm(contact);
            SubmitContactCreation();

            return this;

        }

        public ContactHelper Modify(ContactData contact)
        {
            manager.NavigationHelper.OpenHomePage();
            InitContactModification();
            FillInnContactForm(contact);
            SubmitContactModification();
            manager.NavigationHelper.OpenHomePage();

            return this;

        }

        public ContactHelper Remove()
        {
            manager.NavigationHelper.OpenHomePage();
            SelectContact();
            RemoveContact();
            ConfirmRemoval();
            manager.NavigationHelper.OpenHomePage();

            return this;
        }

        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();

            return this;
        }

        public ContactHelper FillInnContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);

            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();

            return this;
        }

        public ContactHelper SelectContact()
        {
            driver.FindElement(By.Name("selected[]")).Click();

            return this;
        }

        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();

            return this;
        }
        

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();

            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();

            return this;
        }


        public ContactHelper ConfirmRemoval()
        {
            driver.SwitchTo().Alert().Accept();

            return this;
        }



    }
}
