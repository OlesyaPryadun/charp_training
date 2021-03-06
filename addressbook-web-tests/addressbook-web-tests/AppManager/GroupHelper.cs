﻿using System;
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


        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.NavigationHelper.OpenGroupsPage();
            SelectGroup(v);
            InitGroupModification();
            FillInGroupForm(newData);
            SubmiGroupModification();
            ReturnToGroupPage();

            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();

            return this;
        }

        public GroupHelper SubmiGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            groupCache = null;
            return this;
        }


        public GroupHelper Remove(int v)
        {
            manager.NavigationHelper.OpenGroupsPage();
            manager.GroupHelper
                .SelectGroup(v)
                .RemoveGroup()
                .ReturnToGroupPage();
            return this;
        }

        public GroupHelper CreateIfNotExist(GroupData group)
        {
            manager.NavigationHelper.OpenGroupsPage();
            if (GroupsExist())
            {
                return this;
            }

            Create(group);
            return this;
        }

        public bool GroupsExist()
        {
            return IsElementPresent(By.Name("selected[]"));
        }

        public GroupHelper SelectGroup(int index)
        {

            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();

            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='new'])[2]")).Click();

            return this;
        }

        public GroupHelper FillInGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);

            return this;
        }


        public GroupHelper SubmiGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            groupCache = null;
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
            groupCache = null;
            return this;
        }

        private List<GroupData> groupCache = null;

        public List<GroupData> GetGroupList()
        {
            if (groupCache == null)
            {
                groupCache = new List<GroupData>();
                manager.NavigationHelper.OpenGroupsPage();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
                foreach (IWebElement element in elements)
                {
                    groupCache.Add(new GroupData(element.Text) {
                        Id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });
                }

            }

            return new List<GroupData>(groupCache);

        }

        public int GetGroupCount()
        {
            return driver.FindElements(By.CssSelector("span.group")).Count;
        }
    }
}

