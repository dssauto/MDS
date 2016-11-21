using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class RUGIV66GrouperPageTest : BaseSetup
    {
        [Test]
        public void TC044_RUGIV66Grouper_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToAdminPage();
            Driver.WaitFor(2);
            AdminPage.NavigateToRugRates();
            Driver.WaitFor(2);
            RugRatesPage.VerifyPageElements();
        }
    }
}