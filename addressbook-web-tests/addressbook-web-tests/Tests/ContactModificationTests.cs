using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    class ContactModificationTests : AuthTestBase
    {

        [Test]
        public void ContactModification()
        {
            ContactData contact = new ContactData("First Name", "Last Name");

            ContactData newData = new ContactData("updated First Name", "updated Last Name");

            app.ContactHelper.CreateIfNotExist(contact);

            List<ContactData> oldContacts = app.ContactHelper.GetContactList();

            app.ContactHelper.Modify(newData);

            List<ContactData> newContacts = app.ContactHelper.GetContactList();
            oldContacts[0].FirstName = newData.FirstName;
            oldContacts[0].LastName = newData.LastName;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }

    }
} 
