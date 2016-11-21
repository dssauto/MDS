using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class SearchResidentsPageTest : BaseSetup
    {
        [Test]
        public void TC043_SearchResidents_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToResidentHistoryPage();
            Driver.WaitFor(2);
            SearchResidentsPage.VerifyPageElements();
        }
    }
}