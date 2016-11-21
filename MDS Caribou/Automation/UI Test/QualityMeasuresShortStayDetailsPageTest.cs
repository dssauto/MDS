using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class QualityMeasuresShortStayDetailsPageTest : BaseSetup
    {
        [Test]
        public void TC041_QualityMeasuresShortStayDetail_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            //LandingPage.NavigateToReportsFormsPage();
            //DashboardPage.NavigateToQualityMeasures();
            //DashboardPage.NavigateToQualityMeasuresShortStayDetails();
            Driver.Instance.Navigate().GoToUrl("http://cariboudevweb.dssinc.com/CaribouCLCSuite/menu/dashboard/qualityindicatorsshortterm");
            Driver.WaitFor(2);
            QualityMeasuresShortStayDetailsPage.VerifyPageElements();
        }
    }
}