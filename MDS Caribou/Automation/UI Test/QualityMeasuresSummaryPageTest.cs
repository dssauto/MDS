using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class QualityMeasuresSummaryPageTest : BaseSetup
    {
        [Test]
        public void TC042_Dashboard_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            //LandingPage.NavigateToReportsFormsPage();
            //DashboardPage.NavigateToQualityMeasures();
            //DashboardPage.NavigateToQualityMeasuresSummaryPage();
            Driver.Instance.Navigate().GoToUrl("http://cariboudevweb.dssinc.com/CaribouCLCSuite/menu/dashboard/qmsummary");
            Driver.WaitFor(2);
            QualityMeasuresSummaryPage.VerifyPageElements();
        }
    }
}