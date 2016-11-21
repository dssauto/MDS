using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class AM___Approve_New_User_Access___Assign_Role_Discipline: BaseSetup
    {
        [Test]
        public void AM_Approve_New_User_Access_Assign_Role_Discipline()
        {
            Browser.Open();
            //Step 1  Log in as Administrator.
            LoginPage.CreateNewUser("Selenium, Facility");
            LoginPage.Login();
            //Step 2  Click on Notification bell.
            Driver.ClickOn(UserMenu.notificationsIcon);
            //Step 3  Click SEE ALL
            Driver.ClickOn(UserMenu.seeAllButton);
            //Step 4  Click APPROVE ACCESS button.
            Driver.ClickOn(NotificationsPage.approveAccessButton);
            //Step 5  Select Discipline of user requesting access from drop down.
            UserPopupWindow.SelectDiscipline("Pharmacy Services");
            //Step 6  Select checkbox to the left of Role of user requesting access.
            UserPopupWindow.CheckRoles("LPN");
            //Step 7  Click SAVE.
            Driver.ClickOn(UserPopupWindow.saveBtn);
            //Step 8  Select Caribou CLC Suite from upper left hand breadcrumb.
            Driver.PressEnter(UserMenu.caribouCLCSuiteLink);
        }
    }
}
