using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class DashboardPageTest : BaseSetup
    {
        [Test]
        public void TC027_Dashboard_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
            DashboardPage.VerifyPageElements();
        }
    }
}