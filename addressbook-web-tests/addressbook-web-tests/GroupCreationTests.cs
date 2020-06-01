using System;
using System.Text;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        
        [Test]
        public void NewGroupCreation()
        {
            OpenLoginPage();
            Login(new AccountData("admin", "secret"));
            OpenGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("group name");
            group.Header = "header name";
            group.Footer = "footer name";
            FillInGroupForm(group);
            SubmiGroupCreation();
            ReturnToGroupPage();
            Logout();
        }                             
        
    }
}
