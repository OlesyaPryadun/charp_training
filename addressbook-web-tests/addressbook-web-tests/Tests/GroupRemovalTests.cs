using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;



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

            app.GroupHelper.CreateIfNotExist(group);

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.Remove(0);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);

        }
                             
    }
}
