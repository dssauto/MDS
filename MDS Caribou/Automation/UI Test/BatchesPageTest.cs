using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class BatchesPageTest : BaseSetup
    {
        [Test]
        public void TC025_Batches_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToBatchesTransmitPage();
            BatchesTransmitPage.NavigateToBatchesPage();
            BatchesPage.VerifyPageElements();
        }
    }
}