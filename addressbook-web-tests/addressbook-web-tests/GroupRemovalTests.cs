using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;



namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        

        [Test]
        public void GroupRemoval()
        {
            OpenLoginPage();
            Login(new AccountData("admin", "secret"));
            OpenGroupsPage();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupPage();
            Logout();
        }
                             
    }
}
