using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemoval()
        {
            ContactData contact = new ContactData("First Name", "Last Name");

            app.ContactHelper
                .CreateIfNotExist(contact)
                .Remove();
        }

    }
}
