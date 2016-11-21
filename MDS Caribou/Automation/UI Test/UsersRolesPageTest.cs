using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class UsersRolesPageTest : BaseSetup
    {
        [Test]
        public void TC046_UsersRoles_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToAdminPage();
            Driver.WaitFor(1);
            AdminPage.NavigateToUsersRoles();
            Driver.WaitFor(1);
            VerifyElement.AreEqual(UsersRolesPage.pageHeader, "Users & Roles: Selenium, Facility");
            VerifyElement.AreEqual(UsersRolesPage.permissionsLabel, "Permissions");
            VerifyElement.IsPresent(UsersRolesPage.permissionNameColumnLabel);
            VerifyElement.IsPresent(UsersRolesPage.permissionsDescriptionColumnLabel);
            VerifyElement.AreEqual(UsersRolesPage.rolesLabel, "Roles");
            VerifyElement.IsPresent(UsersRolesPage.addRoleButton);
            VerifyElement.AreEqual(UsersRolesPage.roleNameColumnLabel, "Role Name");
            VerifyElement.AreEqual(UsersRolesPage.rolesDescriptionColumnLabel, "Description");
            VerifyElement.AreEqual(UsersRolesPage.rolesPermissionsColumnLabel, "Permissions");
            VerifyElement.IsPresent(UsersRolesPage.rolesView);
            Driver.ClickOn(UsersRolesPage.rolesView);
            VerifyElement.IsPresent(UsersRolesPage.rolesHide);
            VerifyElement.IsPresent(UsersRolesPage.rolesEditButton);
            VerifyElement.AreEqual(UsersRolesPage.disciplinesLabel, "Disciplines");
            VerifyElement.IsPresent(UsersRolesPage.addDisciplineButton);
            VerifyElement.AreEqual(UsersRolesPage.disciplinesNameColumnLabel, "Discipline Name");
            VerifyElement.AreEqual(UsersRolesPage.disciplinesNameColumnLabel, "Discipline Name");
            VerifyElement.AreEqual(UsersRolesPage.disciplinesDescriptionColumnLabel, "Description");
            VerifyElement.IsPresent(UsersRolesPage.disciplinesEditButton);
            VerifyElement.AreEqual(UsersRolesPage.usersLabel, "Users");
            VerifyElement.AreEqual(UsersRolesPage.usersFirstNameColumnLabel, "First Name");
            VerifyElement.AreEqual(UsersRolesPage.usersLastNameColumnLabel, "Last Name");
            VerifyElement.AreEqual(UsersRolesPage.usersUsernameColumnLabel, "Username");
            VerifyElement.AreEqual(UsersRolesPage.usersDisciplineColumnLabel, "Discipline");
            VerifyElement.AreEqual(UsersRolesPage.usersRoleColumnLabel, "Role(s)");
            VerifyElement.IsPresent(UsersRolesPage.usersEditButton);
            VerifyElement.IsPresent(UsersRolesPage.caribouCLSSuiteFooter);
            VerifyElement.IsPresent(UsersRolesPage.versionFooter);
            VerifyElement.IsPresent(UsersRolesPage.userFooter);
            VerifyElement.IsPresent(UsersRolesPage.developedByFooter);

            }
    }
}