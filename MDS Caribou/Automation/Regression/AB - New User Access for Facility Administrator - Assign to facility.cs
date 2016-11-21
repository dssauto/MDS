using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class AB___New_User_Access_for_Facility_Administrator___Assign_to_facility: BaseSetup
    {
        [Test]
        public void AB_New_User_Access_for_Facility_Administrator_Assign_to_facility()
        {
            Browser.Open();
            //Step 1  "On Caribou CLC Suite URL page:
            //        Enter Email Address of New Facility Administrator to be added.
            Driver.InsertText(LoginPage.emailTextField, "autoTest@mail.com");
            //        Enter Password of New Facility Administrator.
            Driver.InsertText(LoginPage.passwordTextField, "Test123!");
            //        Select Facility for New User to receive access.
            Driver.ClickOn(By.XPath("//*[@id='location']/option[normalize-space(text())='Selenium, Facility']"));
            //        Click REGISTER."
            Driver.ClickOn(LoginPage.registerButton);
            //Step 2  "Enter First Name of New Facility Administrator.
            Driver.InsertText(LoginPage.firstnameTextfield, "First Name");
            //        Enter Last Name of New Facility Administrator.
            Driver.InsertText(LoginPage.lastnameTextfield, "Last Name");
            //        Click REGISTER."
            Driver.ClickOn(LoginPage.registerButton);
            VerifyElement.AreEqual(LoginPage.bottomWarningMessage, "Looks like you do not have enough permissions to access Selenium, Facility facility. ");
            //Step 3  Re - enter password and click REQUEST ACCESS.
            Driver.InsertText(LoginPage.passwordTextField, "Test123!");
            Driver.ClickOn(LoginPage.requestAccessButton);
            //Step 4  Sign in as Caribou.
            LoginPage.SignIn();
            //Step 5  Select Admin Tile > Users & Roles from left side menu.
            LandingPage.NavigateToAdminPage();
            SidebarMenu.NavigateToUsersRoles();
            //Step 8  Verify new user added is displayed in list of users.
            Driver.ClickOn(By.XPath("(//a[@class='ng-binding'])[last()]"));
            VerifyElement.AreEqual(By.XPath("(//tr[@class='ng-scope']/td)[last()]//preceding-sibling::td[3]"), "autoTest@mail.com");
            //Step 7  Select Facilities from lefr side menu.
            //Step 6  Select New Facility, Administrator requested access for> ADMIN button.
            //Step 9  Enter last name of Administrator requesting access in User Name box.Click highlighted name.
            //Step 10 Click SAVE.
            //Step 11 Click ADMIN button.
        }
    }
}
