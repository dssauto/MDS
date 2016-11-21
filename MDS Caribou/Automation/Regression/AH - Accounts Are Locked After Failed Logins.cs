using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class AH___Accounts_Are_Locked_After_Failed_Logins : BaseSetup
    {
        [Test]
        public void AH_Accounts_Are_Locked_After_Failed_Logins()
        {
            Browser.Open();
            //Step 1  "On Caribou CLC Suite URL page:
            //        Enter valid Email Address of Caribou user.
            //        Enter invalid Password of Caribou User.
            //        Enter valid Facilities from Select Facility drop down.
            //        Click SIGN IN button."
            LoginPage.SignInManually("SeleniumNurse@va.gov", "dss.123", "Selenium, Facility");
            VerifyElement.AreEqual(LoginPage.warningMessage, "The user name or password is incorrect.");
            //Step 2  "On Caribou CLC Suite URL page:
            //        Enter valid Email Address of Caribou user.
            //        Enter invalid Password of Caribou User.
            //        Enter valid Facilities from Select Facility drop down.
            //        Click SIGN IN button."
            LoginPage.SignInManually("SeleniumNurse@va.gov", "dss.123", "Selenium, Facility");
            VerifyElement.AreEqual(LoginPage.warningMessage, "The user name or password is incorrect.");
            //Step 3  "On Caribou CLC Suite URL page:
            //        Enter valid Email Address of Caribou user.
            //        Enter invalid Password of Caribou User.
            //        Enter valid Facilities from Select Facility drop down.
            //        Click SIGN IN button."
            LoginPage.SignInManually("SeleniumNurse@va.gov", "dss.123", "Selenium, Facility");
            VerifyElement.AreEqual(LoginPage.warningMessage, "The user name or password is incorrect.");
            //Step 4  "On Caribou CLC Suite URL page:
            //        Enter valid Email Address of Caribou user.
            //        Enter invalid Password of Caribou User.
            //        Enter valid Facilities from Select Facility drop down.
            //        Click SIGN IN button."
            LoginPage.SignInManually("SeleniumNurse@va.gov", "dss.123", "Selenium, Facility");
            LoginPage.SignInManually("SeleniumNurse@va.gov", "dss.123", "Selenium, Facility");
            VerifyElement.AreEqual(LoginPage.warningMessage, "Account is locked, please contact your facility administrator.");
            //Step 5  Click forgot password
            Driver.ClickOn(LoginPage.forgotPasswordorExpiredLink);
            VerifyElement.AreEqual(LoginPage.warningMessage, "Account is locked, please contact your facility administrator.");
            Browser.GoBack();
            //Step 6  "On Caribou CLC Suite URL page:
            //        Enter valid Email Address of Caribou user.
            //        Enter valid Password of Caribou User.
            //        Enter valid Facilities from Select Facility drop down.
            //        Click SIGN IN button."
            LoginPage.SignInManually("SeleniumNurse@va.gov", "Dss.1234", "Selenium, Facility");
            VerifyElement.AreEqual(LoginPage.warningMessage, "Account is locked, please contact your facility administrator.");
            //Step 7  "On Caribou CLC Suite URL page login as facility administrator:
            //        Enter valid Email Address of Caribou user.
            //        Enter valid Password of Caribou User.
            //        Enter valid Facilities from Select Facility drop down.
            //        Click SIGN IN button."
            LoginPage.SignInManually("Seleniumadmin@va.gov", "Dss.1234", "Selenium, Facility");
            //Step 8  Click Notification bell
            Driver.ClickOn(UserMenu.notificationsIcon);
            //Step 9  Click SEE ALL button
            Driver.ClickOn(UserMenu.seeAllButton);
            //Step 10 Click UNLOCK ACCOUNT button for locked facility
            Driver.ClickOn(NotificationsPage.unlockAccountBtn);
            //Step 11 Click Account Lock slide button
            Driver.ClickOn(UserPopupWindow.lockedBtn);
            //Step 12 Click SAVE button
            Driver.ClickOn(UserPopupWindow.saveBtn);
            //Step 13 Sing out from facility administrator
            UserMenu.SignOut();
            //Step 13 "On Caribou CLC Suite URL page as user which was locked before.
            //        Enter valid Email Address of Caribou user.
            //        Enter valid Password of Caribou User.
            //        Enter valid Facilities from Select Facility drop down.
            //        Click SIGN IN button."
            LoginPage.SignInManually("SeleniumNurse@va.gov", "Dss.1234", "Selenium, Facility");
            VerifyElement.IsPresent(LandingPage.workInProgressTile);
        }
    }
}
