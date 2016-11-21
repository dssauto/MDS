using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class AssessmentsPageTest : BaseSetup
    {
        [Test]
        public void TC024_Assessments_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToBatchesTransmitPage();
            BatchesTransmitPage.NavigateToAssessmentsPage();
            Driver.WaitFor(2);
            AssessmentsPage.VerifyPageElements();

        }
    }
}