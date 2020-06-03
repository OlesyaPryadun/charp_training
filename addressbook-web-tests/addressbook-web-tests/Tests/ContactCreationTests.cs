using System;
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
            app.ContactHelper.InitContactCreation();
            app.ContactHelper.FillInnContactForm(new ContactData ("First Name", "Last Name"));
            app.ContactHelper.SubmitContactCreation();
            app.NavigationHelper.OpenHomePage();
        }
    
    }
}
