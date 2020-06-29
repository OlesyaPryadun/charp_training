using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    class GroupModificationTests : AuthTestBase
    {


            [Test]
            public void GroupModification()
            {

                GroupData group = new GroupData("group name");
                group.Header = "header name";
                group.Footer = "footer name";
  
                GroupData newData = new GroupData("updated group name");
                newData.Header = "updated header name";
                newData.Footer = "updated footer name";

                app.GroupHelper.CreateIfNotExist(group);

                List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

                app.GroupHelper.Modify(0, newData);


                List<GroupData> newGroups = app.GroupHelper.GetGroupList();
                oldGroups[0].Name = newData.Name;
                oldGroups.Sort();
                newGroups.Sort();
                Assert.AreEqual(oldGroups, newGroups);

            }


        }
    }


