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

                GroupData newData = new GroupData("updated group name");
                newData.Header = "updated header name";
                newData.Footer = "updated footer name";

                app.GroupHelper.Modify(1, newData);
            }


        }
    }


