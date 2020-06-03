using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;


namespace addressbook_web_tests
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {

            app = new ApplicationManager();
            app.NavigationHelper.OpenLoginPage();
            app.Auth.Login(new AccountData("admin", "secret"));

        }

        [TearDown]
        public void TeardownTest()
        {
            app.Auth.Logout();
            app.Stop();
        }

    }
}
