using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class AJ___Users_Roles___Assign_Permissions__Sections_to_Role: BaseSetup
    {
        [Test]
        public void AJ_Users_Roles_Assign_Permissions_Sections_to_Role()
        {
            Browser.Open();
            //Step 1  Log in as Facility Administrator.
            LoginPage.SignIn();
            //Step 2  Select Admin Tile > Users & Roles from left side menu.
            LandingPage.NavigateToAdminPage();
            SidebarMenu.NavigateToUsersRoles();
            //Step 3  Select EDIT button on Role for Permissions / Sections to be assigned
            //Step 4  "*Based on users Role*
            //        Use attached document to select Permissions to be assigned by checking the checkboxes associated to the appropriate permissions.
            //        Description in hover to each Permission."
            //Step 5  "*Based on users Role*
            //        Use attached document to select Sections to be assigned by selecting SELECT SECTION ITEM PERMISSOINS and then selecting appropriate sections and questions from options on right."
            //Step 6  Click SAVE.
            //Step 7  Select View from Permissions column drop down arrow in Roles display and verify the Permissions given when creating Role match Permissions displayed.

        }
    }
}
