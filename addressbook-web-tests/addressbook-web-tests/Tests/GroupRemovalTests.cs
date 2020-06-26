using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;



namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
       
        [Test]
        public void GroupRemoval()
        {
            GroupData group = new GroupData("group name");
            group.Header = "header name";
            group.Footer = "footer name";

            app.GroupHelper
                .CreateIfNotExist(group)
                .Remove(1);

        }
                             
    }
}
