using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class AG___Change_Password: BaseSetup
    {
        [Test]
        public void AG_Change_Password()
        {
            Browser.Open();
            //Step 1  Sign in to Caribou CLC Suite as any User.
            LoginPage.SignIn();
            //Step 2  Select User Icon from upper right hand corner> Account Settings.
            UserMenu.NavigateToAccountSettingsPage();
            //Step 3  "Enter Current Password in Current Password box.
            Driver.InsertText(UserAccountPage.currentPasswordTextfield, "Dss.1234");
            //        Enter New Password in New Password box.
            Driver.InsertText(UserAccountPage.newPasswordTextfield, "Dss.12345");
            //        Re - enter New Password in Confirm New Password box.
            Driver.InsertText(UserAccountPage.confirmNewPasswordTextfiled, "Dss.12345");
            //        Click CHANGE PASSWORD"
            Driver.ClickOn(UserAccountPage.changePasswordButton);
            //Step 4  Select User Icon from upper right hand corner> Sign Out.
            UserMenu.SignOut();
            //Step 5  Sign in to Caribou CLC Suite as the same user with the New Password.
            LoginPage.SignInManually("Seleniumadmin@va.gov", "Dss.12345", "Selenium, Facility");
            // Change password back
            UserMenu.NavigateToAccountSettingsPage();
            Driver.InsertText(UserAccountPage.currentPasswordTextfield, "Dss.12345");
            Driver.InsertText(UserAccountPage.newPasswordTextfield, "Dss.1234");
            Driver.InsertText(UserAccountPage.confirmNewPasswordTextfiled, "Dss.1234");
            Driver.ClickOn(UserAccountPage.changePasswordButton);
            UserMenu.SignOut();
            LoginPage.SignInManually("Seleniumadmin@va.gov", "Dss.1234", "Selenium, Facility");
        }
    }
}
