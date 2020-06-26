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

            app.ContactHelper
                .CreateIfNotExist(contact)
                .Modify(newData);
        }

    }
} 
