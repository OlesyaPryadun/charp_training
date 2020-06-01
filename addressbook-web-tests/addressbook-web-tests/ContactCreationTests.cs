﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
       
        [Test]
        public void NewContactCreation()
        {
            OpenLoginPage();
            Login(new AccountData("admin", "secret"));
            InitContactCreation();           
            FillInnContactForm(new ContactData ("First Name", "Last Name"));
            SubmitContactCreation();
            OpenHomePage();
            Logout();
        }
    
    }
}
