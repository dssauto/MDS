using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class AI___Users__Roles___Add_Roles_Edit_Role_Delete_Role: BaseSetup
    {
        [Test]
        public void AI_Users_Roles_Add_Roles_Edit_Role_Delete_Role()
        {
            Browser.Open();
            //Step 1  Log in as Facility Administrator.
            LoginPage.SignIn();
            //Step 2  Select Admin Tile > Users & Roles from left side menu.
            LandingPage.NavigateToAdminPage();
            SidebarMenu.NavigateToUsersRoles();
            //Step 3  "Roles
            UsersRolesPage.VerifyDefaultFacilityRoles();
            //        Verify 26 Default Facility Roles are displayed.
            //        Facility Administrator
            //        Administrative Support
            //        Central Office
            //        Chaplian
            //        IRM
            //        IT
            //        IS
            //        Resident Assessment Coordinator
            //        Resident Assessment Nurse
            //        Registered Nurse
            //        Medical Provider
            //        Recreation Therapist
            //        Registered Dietitian
            //        Social Worker
            //        Occupational Therapist
            //        Physical Therapist
            //        Coder
            //        Registered Pharmacist
            //        Psychologist
            //        Kinesiotherapist
            //        Respiratory Therapist
            //        Speech Therapist
            //        CNA
            //        LPN
            //        Quality Management
            //        Therapy Assistants"
            //Step 4  Select + ADD ROLE
            Driver.ClickOn(UsersRolesPage.addRoleButton);
            //Step 5  "Enter Role Name: Test Role
            Driver.InsertText(FacilityRolePage.roleNameTextField, "Auto Role");
            //        Enter Description: Test Description
            Driver.InsertText(FacilityRolePage.descriptionTextField, "Auto Description");
            //        Permissions: Assign Permissions Write Assessments, Write Residents, Read Residents, Write Reports and Account Settings. 
            Driver.ClickRadioButton(FacilityRolePage.writeAssessmentsCheckbox);
            Driver.ClickRadioButton(FacilityRolePage.writeResidentsCheckbox);
            Driver.ClickRadioButton(FacilityRolePage.readResidentsCheckbox);
            Driver.ClickRadioButton(FacilityRolePage.writeReportsCheckbox);
            Driver.ClickRadioButton(FacilityRolePage.accountSettingsCheckbox);
            //        Verify SELECT SECTION ITEM PERMISSIONS becomes active."
            //Step 6  Select SELECT SECTION ITEM PERMISSIONS
            Driver.ClickOn(FacilityRolePage.selectSectionItemPermissionsButton);
            Driver.WaitFor(2);
            //Step 7  "Select Sections and Section questions for Test Role.
            //        E.g.Section A, B, C-C0100, C0200, Z0400.
            //        Click SAVE
            //        Verify New role created and displays in list."
            Driver.ClickOn(FacilityRolePage.saveButton);
            //Step 8  Select View from Permissions column drop down arrow in Roles display and verify the Permissions given when creating Role match Permissions displayed.
            Driver.ClickOn(UsersRolesPage.rolesLastPagination);
            Driver.WaitFor(1);
            Driver.ClickOn(By.XPath("//tr[@class='ng-scope' and @ng-repeat='role in roles.list']//a"));
            //Step 9  Select EDIT button on Test Role.
            Driver.ClickOn(By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']//button[@class='btn btn-info btn-xs'])[last()]"));
            //Step 10 "Add Permissions: Write Settings.
            //        Remove Permissions: Write Assessments.
            //        Click SAVE"
            Driver.ClickOn(FacilityRolePage.saveButton);
            //Step 11 Select View from Permissions column drop down arrow in Roles display and verify the Permissions given when creating Role match Permissions displayed.
            //Step 12 Select EDIT button on Test Role.
            Driver.ClickOn(UsersRolesPage.rolesLastPagination);
            Driver.ClickOn(By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']//button[@class='btn btn-info btn-xs'])[last()]"));
            Driver.WaitForElement(FacilityRolePage.deleteBtn);
            //Step 13 Select DELETE.
            Driver.ClickOn(FacilityRolePage.deleteBtn);
            //Step 14 Select Yes.
            Driver.ClickOn(FacilityRolePage.yesBtn);
            //Step 15 Verify Test Role no longer displays in list of Roles.
            Driver.WaitFor(2);
            VerifyElement.IsNotPresent(By.XPath("//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[contains(.,'Auto Role')]"));
        }
    }
}
