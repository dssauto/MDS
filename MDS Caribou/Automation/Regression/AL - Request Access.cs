using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class AL___Request_Access: BaseSetup
    {
        [Test]
        public void AL_Request_Access()
        {
            Browser.Open();
            //LoginPage.SignIn();
            //Step 1  On Caribou CLC URL page.
            //Step 2  "Enter Email address of User requesting access in Email Address box.
            Driver.InsertText(LoginPage.emailTextField, RandomNameHelper.WithSpecialCharacter(8) + "@mail.com");
            //        Enter Password of User requesting access in Password box.
            Driver.InsertText(LoginPage.passwordTextField, "Test1234!");
            //        User drop down arrow in Select Facility box to select appropriate facility for User requesting access.
            Driver.ClickOn(By.XPath("//*[@id='location']/option[normalize-space(text())='Selenium, Facility']"));
            //        Clcik REGISTER"
            Driver.ClickOn(LoginPage.registerButton);
            //Step 3  "Re-enter Password.
            //        Enter Users First Name in First Name box.
            Driver.InsertText(LoginPage.firstnameTextfield, "FirstName");
            //        Enter Users Last Name in Last Name box.
            Driver.InsertText(LoginPage.lastnameTextfield, "LastName");
            //        Click REGISTER."
            Driver.ClickOn(LoginPage.registerButton);
            //Step 4  "Re-enter password (at this point we are all tired of entering the password).
            //        Click REQUEST ACCESS"
            Driver.InsertText(LoginPage.passwordTextField, "Test1234!");
            Driver.ClickOn(LoginPage.requestAccessButton);
        }
    }
}
