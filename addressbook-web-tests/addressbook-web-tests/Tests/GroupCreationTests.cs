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
                     
            GroupData group = new GroupData("group name");
            group.Header = "header name";
            group.Footer = "footer name";

            app.GroupHelper.Create(group); 
        }

        [Test]
        public void NewEmptyGroupCreation()
        {
            
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.GroupHelper.Create(group);
        }

    }
}
