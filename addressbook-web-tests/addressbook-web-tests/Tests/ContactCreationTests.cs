using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
       
        [Test]
        public void NewContactCreation()
        {
            ContactData newData = new ContactData("First Name", "Last Name");

            app.ContactHelper.Create(newData);
        }
    
    }
}
