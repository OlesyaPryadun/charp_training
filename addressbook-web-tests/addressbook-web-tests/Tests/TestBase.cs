using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;


namespace addressbook_web_tests
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        private void SetupApplicationManager()
        {

            app = ApplicationManager.GetInstance();

        }

    }
}
