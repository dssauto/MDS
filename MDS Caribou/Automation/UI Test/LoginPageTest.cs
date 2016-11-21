using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class LoginPageTest : BaseSetup
    {
        [Test]
        public void TC001_LoginPage_Validation()
        {
            Browser.Open();
            LoginPage.VerifyPageElements();
        }
        [Test]
        public void TC002_ValidSignIn_Validation()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Driver.WaitFor(2);
            UserMenu.SignOut();
        }
        [Test]
        public void TC003_InvalidPassword_Validation()
        {
            Browser.Open();
            Driver.InsertText(LoginPage.emailTextField, "durango@dssinc.com");
            Driver.InsertText(LoginPage.passwordTextField, "invalid");
            Driver.SelectDropdown(LoginPage.selectFacilityDropdown, "Selenium, Facility");
            Driver.PressEnter(LoginPage.signinButton);
            VerifyElement.AreEqual(LoginPage.warningMessage, "The user name or password is incorrect.");
        }
        [Test]
        public void TC004_SelectFacility_Validation()
        {
            Browser.Open();
            Driver.InsertText(LoginPage.emailTextField, "durango@dssinc.com");
            Driver.InsertText(LoginPage.passwordTextField, "Dss.1234");
            Driver.PressEnter(LoginPage.signinButton);
            VerifyElement.AreEqual(LoginPage.warningMessage, "Please select a facility");
        }
        [Test]
        public void TC005_ForgotPassword_Validation()
        {
            Browser.Open();
            LoginPage.SubmitForgotPassword("AutoTest@email.com", "Selenium, Facility");
        }
        [Test]
        public void TC006_RegisterNewUser_Validation()
        {
            Browser.Open();
            LoginPage.Register("newUser@email.com ", "Password1", "first", "last", "Selenium, Facility");
        }
    }
}
