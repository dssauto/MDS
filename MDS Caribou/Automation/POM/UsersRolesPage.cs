using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class UsersRolesPage
    {
        #region WebElements
        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By adminNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By facilityUsersNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");
        static internal By rolesLastPagination = By.XPath("(//ul[@items-per-page='roles.pageSize']//a[@class='ng-binding'])[last()]");
        static internal By disciplinesLastPagination = By.XPath("(//ul[@items-per-page='disciplines.pageSize']//a[@class='ng-binding'])[last()]");

        //Permissions
        static internal By permissionsLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/span");
        static internal By permissionNameColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/table/thead/tr/th[1]");
        static internal By permissionsDescriptionColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/table/thead/tr/th[2]");

        //Roles
        static internal By rolesLabel = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/span");
        static internal By addRoleButton = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/button");
        static internal By roleNameColumntLabel = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/table/thead/tr/th[1]");
        static internal By rolesDescriptionColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/table/thead/tr/th[2]");
        static internal By rolesPermissionsColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/table/thead/tr/th[3]");
        static internal By rolesViewDropdown = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/table/tbody/tr[1]/td[3]/a[1]");
        static internal By rolesHideDropdown = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/table/tbody/tr[1]/td[3]/a[2]");
        static internal By rolesEditButton = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/table/tbody/tr[1]/td[4]/button");
        static internal By roleNameColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/table/thead/tr/th[1]");
        static internal By rolesView = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/table/tbody/tr[1]/td[3]/a[1]");
        static internal By rolesHide = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/table/tbody/tr[1]/td[3]/a[2]");

        // 26 Roles
        static internal By facilityAdministrator = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[1]");
        static internal By administrativeSupport = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[2]");
        static internal By centralOffice = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[3]");
        static internal By chaplain = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[4]");
        static internal By irm = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[5]");
        static internal By iT = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[1]");
        static internal By iS = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[2]");
        static internal By residentAssessmentCoordinator = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[3]");
        static internal By residentAssessmentNurse = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[4]");
        static internal By registeredNurse = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[5]");
        static internal By medicalProvider = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[1]");
        static internal By recreationTherapist = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[2]");
        static internal By registeredDietitian = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[3]");
        static internal By socialWorker = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[4]");
        static internal By occupationalTherapist = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[5]");
        static internal By physicalTherapist = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[1]");
        static internal By coder = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[2]");
        static internal By registeredPharmacist = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[3]");
        static internal By psychologist = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[4]");
        static internal By kinesiotherapist = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[5]");
        static internal By respiratoryTherapist = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[1]");
        static internal By speechTherapist = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[2]");
        static internal By cNA = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[3]");
        static internal By lPN = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[4]");
        static internal By qualityManagement = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[5]");
        static internal By therapyassistants = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='role in roles.list']/td[2][@class='ng-binding'])[1]");


        //Disciplines
        static internal By disciplinesLabel = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/span");
        static internal By addDisciplineButton = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/button");
        static internal By disciplinesNameColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/table/thead/tr/th[1]");
        static internal By disciplinesDescriptionColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/table/thead/tr/th[2]");
        static internal By disciplinesEditButton = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/table/tbody/tr[1]/td[3]/button");

        //Users
        static internal By usersLabel = By.XPath("//*[@id='main-content']/div/div/div[4]/div/div/span");
        static internal By usersFirstNameColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[4]/div/div/table/thead/tr/th[1]");
        static internal By usersLastNameColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[4]/div/div/table/thead/tr/th[2]");
        static internal By usersUsernameColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[4]/div/div/table/thead/tr/th[3]");
        static internal By usersDisciplineColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[4]/div/div/table/thead/tr/th[4]");
        static internal By usersRoleColumnLabel = By.XPath("//*[@id='main-content']/div/div/div[4]/div/div/table/thead/tr/th[5]");
        static internal By usersEditButton = By.XPath("(//button[@ng-click='openEditUserModal(user)'])[1]");

        // Default Facility Disciplines
        static internal By nursingServices = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='discipline in disciplines.list']/td[2][@class='ng-binding'])[1]");
        static internal By physicianServices = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='discipline in disciplines.list']/td[2][@class='ng-binding'])[2]");
        static internal By rehabilitationServices = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='discipline in disciplines.list']/td[2][@class='ng-binding'])[3]");
        static internal By therapyServices = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='discipline in disciplines.list']/td[2][@class='ng-binding'])[4]");
        static internal By dietaryServices = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='discipline in disciplines.list']/td[2][@class='ng-binding'])[5]");

        static internal By socialServices = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='discipline in disciplines.list']/td[2][@class='ng-binding'])[1]");
        static internal By administrativeServices = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='discipline in disciplines.list']/td[2][@class='ng-binding'])[2]");
        static internal By chaplainServices = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='discipline in disciplines.list']/td[2][@class='ng-binding'])[3]");
        static internal By pharmacyServices = By.XPath("(//tr[@class='ng-scope' and @ng-repeat='discipline in disciplines.list']/td[2][@class='ng-binding'])[4]");
        // Facility Discipline
        static internal By disciplineNameTextfield = By.Id("DisciplineName");
        static internal By descriptionTextfield = By.Id("Description");
        static internal By facilityDisciplineSaveBtn = By.XPath("//button[@ng-click='saveDiscipline()']");
        static internal By facilityDisciplineDeleteBtn = By.XPath("(//button[@ng-click='deleteCollapsed = !deleteCollapsed'])[1]");
        static internal By yesBtn = By.XPath("//button[@ng-click='deleteDiscipline()']");
        //Bottom
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");
        #endregion

        #region Action
        internal static void VerifyDefaultFacilityDisciplines()
        {
            VerifyElement.AreEqual(nursingServices, "Default facility nursing services");
            VerifyElement.AreEqual(physicianServices, "Default facility physician services");
            VerifyElement.AreEqual(rehabilitationServices, "Default facility rehabilitation services");
            VerifyElement.AreEqual(therapyServices, "Default facility therapy services");
            VerifyElement.AreEqual(dietaryServices, "Default facility dietary services");

            Driver.ClickOn(By.XPath("(//a[@class='ng-binding'][text()='2'])[3]"));
            Driver.WaitForElement(socialServices);
            VerifyElement.AreEqual(socialServices, "Default facility social services");
            VerifyElement.AreEqual(administrativeServices, "Default facility administrative services");
            VerifyElement.AreEqual(chaplainServices, "Default facility chaplain services");
            VerifyElement.AreEqual(pharmacyServices, "Default facility pharmacy services");
        }
        internal static void VerifyDefaultFacilityRoles()
        {
            VerifyElement.AreEqual(facilityAdministrator, "Default facility administrator");
            VerifyElement.AreEqual(administrativeSupport, "Default facility administrative support");
            VerifyElement.AreEqual(centralOffice, "Default central office");
            VerifyElement.AreEqual(chaplain, "Default chaplain");
            VerifyElement.AreEqual(irm, "Default IRM");
            Driver.ClickOn(By.XPath("(//a[@class='ng-binding'][text()='2'])[2]"));
            Driver.WaitForElement(iS);
            VerifyElement.AreEqual(iT, "Default IT");
            VerifyElement.AreEqual(iS, "Default IS");
            VerifyElement.AreEqual(residentAssessmentCoordinator, "Default facility coordinator");
            VerifyElement.AreEqual(residentAssessmentNurse, "Default facility assessment nurse");
            VerifyElement.AreEqual(registeredNurse, "Default facility registered nurse");
            Driver.ClickOn(By.XPath("(//a[@class='ng-binding'][text()='3'])[2]"));
            Driver.WaitForElement(medicalProvider);
            VerifyElement.AreEqual(medicalProvider, "Default facility medical provider");
            VerifyElement.AreEqual(recreationTherapist, "Default facility recreation therapist");
            VerifyElement.AreEqual(registeredDietitian, "Default facility registered dietitian");
            VerifyElement.AreEqual(socialWorker, "Default facility social worker");
            VerifyElement.AreEqual(occupationalTherapist, "Default facility occupational therapist");
            Driver.ClickOn(By.XPath("(//a[@class='ng-binding'][text()='4'])[2]"));
            Driver.WaitForElement(physicalTherapist);
            VerifyElement.AreEqual(physicalTherapist, "Default facility physical therapist");
            VerifyElement.AreEqual(coder, "Default facility coder");
            VerifyElement.AreEqual(registeredPharmacist, "Default facility registered pharmacist");
            VerifyElement.AreEqual(psychologist, "Default facility psychologist");
            VerifyElement.AreEqual(kinesiotherapist, "Default facility kinesiotherapist");
            Driver.ClickOn(By.XPath("//a[@class='ng-binding'][text()='5']"));
            Driver.WaitForElement(respiratoryTherapist);
            VerifyElement.AreEqual(respiratoryTherapist, "Default facility respiratory therapist");
            VerifyElement.AreEqual(speechTherapist, "Default facility speech therapist");
            VerifyElement.AreEqual(cNA, "Default facility CNA");
            VerifyElement.AreEqual(lPN, "Default facility LPN");
            VerifyElement.AreEqual(qualityManagement, "Default facility Quality Management");
            Driver.ClickOn(By.XPath("//a[@class='ng-binding'][text()='6']"));
            Driver.WaitForElement(therapyassistants);
            VerifyElement.AreEqual(therapyassistants, "Default facility Therapy assistants");
        }
        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite");

            //Permissions
            VerifyElement.AreEqual(pageHeader, "Users & Roles: Selenium, Facility");
            VerifyElement.AreEqual(permissionsLabel, "Permissions");
            VerifyElement.AreEqual(permissionNameColumnLabel, "Permission Name");
            VerifyElement.AreEqual(permissionsDescriptionColumnLabel, "Description");

            //Roles
            VerifyElement.AreEqual(rolesLabel, "Roles");
            VerifyElement.IsPresent(addRoleButton);
            VerifyElement.AreEqual(roleNameColumntLabel, "Role Name");
            VerifyElement.AreEqual(rolesDescriptionColumnLabel, "Description");
            VerifyElement.AreEqual(rolesPermissionsColumnLabel, "Permissions");
            VerifyElement.IsPresent(rolesViewDropdown);
            VerifyElement.IsPresent(rolesHideDropdown);
            VerifyElement.IsPresent(rolesEditButton);

            //Disciplines
            VerifyElement.AreEqual(disciplinesLabel, "Disciplines");
            VerifyElement.IsPresent(addDisciplineButton);
            VerifyElement.AreEqual(disciplinesNameColumnLabel, "Discipline Name");
            VerifyElement.AreEqual(disciplinesDescriptionColumnLabel, "Disciplines");
            VerifyElement.IsPresent(disciplinesEditButton);

            //Users
            VerifyElement.AreEqual(usersLabel, "Users");
            VerifyElement.AreEqual(usersFirstNameColumnLabel, "First Name");
            VerifyElement.AreEqual(usersLastNameColumnLabel, "Last Name");
            VerifyElement.AreEqual(usersUsernameColumnLabel, "Username");
            VerifyElement.AreEqual(usersDisciplineColumnLabel, "Discipline");
            VerifyElement.AreEqual(usersRoleColumnLabel, "Role(s)");
            VerifyElement.IsPresent(usersEditButton);

        }
        #endregion

        #region Navigation


        #endregion
    }
}