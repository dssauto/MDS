using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class QMFacilityCharacteristicsPageTest : BaseSetup
    {
        [Test]
        public void TC039_Dashboard_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            //LandingPage.NavigateToReportsFormsPage();
            //DashboardPage.NavigateToQualityMeasures
            //DashboardPage.NavigateToQMFacilityCharacteristics
            Driver.Instance.Navigate().GoToUrl("http://cariboudevweb.dssinc.com/CaribouCLCSuite/menu/dashboard/qmfacilitycharacteristics");
            Driver.WaitFor(2);
            QMFacilityCharacteristicsPage.VerifyPageElements();
        }
    }
}