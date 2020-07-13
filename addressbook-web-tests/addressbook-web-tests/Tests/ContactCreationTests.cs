using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
       
        [Test]
        public void NewContactCreation()
        {
            ContactData newData = new ContactData("First Name", "Last Name");

            List<ContactData> oldContacts = app.ContactHelper.GetContactList();

            app.ContactHelper.Create(newData);

            List<ContactData> newContacts = app.ContactHelper.GetContactList();
            oldContacts.Add(newData);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    
    }
}
