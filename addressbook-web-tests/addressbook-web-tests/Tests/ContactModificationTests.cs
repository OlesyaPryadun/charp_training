using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    class ContactModificationTests : TestBase
    {

        [Test]
        public void ContactModification()
        {

            ContactData newData = new ContactData("updated First Name", "updated Last Name");

            app.ContactHelper.Modify(newData);
        }

    }
} 
