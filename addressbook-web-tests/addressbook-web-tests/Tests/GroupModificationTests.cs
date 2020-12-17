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

                GroupData newGroupData = new GroupData("group name");
                newGroupData.Header = "header name";
                newGroupData.Footer = "footer name";
  
                GroupData updatedGroupData = new GroupData("updated group name");
                updatedGroupData.Header = "updated header name";
                updatedGroupData.Footer = "updated footer name";

                app.GroupHelper.CreateIfNotExist(newGroupData);

                List<GroupData> oldGroups = app.GroupHelper.GetGroupList();
                GroupData oldData = oldGroups[0];

                app.GroupHelper.Modify(0, updatedGroupData);

                Assert.AreEqual(oldGroups.Count, app.GroupHelper.GetGroupCount());


                List<GroupData> newGroups = app.GroupHelper.GetGroupList();
                oldGroups[0].Name = updatedGroupData.Name;
                oldGroups.Sort();
                newGroups.Sort();
                Assert.AreEqual(oldGroups, newGroups);

                foreach (GroupData group in newGroups)
                {
                    if (group.Id == oldData.Id)
                    {
                    Assert.AreEqual(updatedGroupData.Name, group.Name);
                    }
                }

            }


        }
    }


