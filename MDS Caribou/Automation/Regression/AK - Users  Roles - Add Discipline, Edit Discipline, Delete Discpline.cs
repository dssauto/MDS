using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class AK___Users__Roles___Add_Discipline__Edit_Discipline__Delete_Discpline: BaseSetup
    {
        [Test]
        public void AK_Users_Roles_Add_Discipline_Edit_Discipline_Delete_Discpline()
        {
            Browser.Open();
            //Step 1  Log in as Facility Administrator.
            LoginPage.SignIn();
            //Step 2  Select Admin Tile > Users & Roles from left side menu.
            LandingPage.NavigateToAdminPage();
            SidebarMenu.NavigateToUsersRoles();
            //Step 3  "Disciplines
            UsersRolesPage.VerifyDefaultFacilityDisciplines();
            //        Verify 9 Default Facility Disciplines are displayed.
            //        Nursing Services
            //        Physician Services
            //        Rehabilitation Services
            //        Therapy Services
            //        Dietary Services
            //        Social Services
            //        Administrative Services
            //        Chaplain Services
            //        Pharmacy Services"
            //Step 4  Select + ADD DISCIPLINE.
            Driver.ClickOn(UsersRolesPage.addDisciplineButton);
            //Step 5  "Enter a Discipline Name to be added in Discipline Name box.  (Test Discipline)
            Driver.InsertText(UsersRolesPage.disciplineNameTextfield, "Test Discipline");
            //        Enter a Description for Discpline in Description box.  (Test Description)
            Driver.InsertText(UsersRolesPage.descriptionTextfield, "Test Description");
            //        Click SAVE."
            Driver.ClickOn(UsersRolesPage.facilityDisciplineSaveBtn);
            Driver.WaitFor(2);
            //Step 6  Select Edit button next to Test Discpline created.
            Driver.ClickOn(By.XPath("(//td[@class='ng-binding'][text()='Test Discipline']//parent::tr/td/button)[last()]"));
            //Step 7  "Edit Name and Description boxes.
            Driver.InsertText(UsersRolesPage.disciplineNameTextfield, "Test Discipline Edit");
            //        Click SAVE."
            Driver.ClickOn(UsersRolesPage.facilityDisciplineSaveBtn);
            //Step 8  Select Edit button next to Edit Test Discipline.
            Driver.ClickOn(By.XPath("(//td[@class='ng-binding'][text()='Test Discipline Edit']//parent::tr/td/button)[last()]"));
            //Step 9  Click DELETE button.
            Driver.ClickOn(UsersRolesPage.facilityDisciplineDeleteBtn);
            //Step 10 Click YES.
            Driver.ClickOn(UsersRolesPage.yesBtn);
            //Step 11 Verify Deleted Discipline no longer displays in Disciplines list.
            VerifyElement.IsNotPresent(By.XPath("(//td[@class='ng-binding'][text()='Test Discipline Edit']//parent::tr/td/button)[last()]"));
        }
    }
}
