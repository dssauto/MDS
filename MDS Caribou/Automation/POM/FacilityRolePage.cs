using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class FacilityRolePage
    {
        #region WebElements

        static internal By pageHeader = By.XPath("//*[@id='mds']/div[1]/div/div/div[1]/h3");
        static internal By roleNameLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[1]/label");
        static internal By roleNameTextField = By.Id("roleName");
        static internal By descriptionLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[2]/label");
        static internal By descriptionTextField = By.Id("description");
        static internal By checkedUncheckedText = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[2]/small");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/div[1]/div[2]/button[1]");
        static internal By saveButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/div[1]/div[2]/button[2]");
        static internal By deleteBtn = By.XPath("//button[@class='btn btn-default'][contains (.,'Delete')]");
        static internal By yesBtn = By.XPath("(//button[2])[last()]");

        //Permissions
        static internal By permissionsLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/label");
        static internal By readUsersCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[1]/div/label/div");
        static internal By writeUsersCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[2]/div/label/div");
        static internal By readAssessmentsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[3]/div/label/div");
        static internal By writeAssessmentsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[4]/div/label/div");
        static internal By manageAssessmentsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[5]/div/label/div");
        static internal By readResidentsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[6]/div/label/div");
        static internal By writeResidentsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[7]/div/label/div");
        static internal By readScheduleCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[8]/div/label/div");
        static internal By writeScheduleCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[9]/div/label/div");
        static internal By readBatchesCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[10]/div/label/div");
        static internal By writeBatchesCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[11]/div/label/div");
        static internal By readReportsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[12]/div/label/div");
        static internal By writeReportsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[13]/div/label/div");
        static internal By readSettingsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[14]/div/label/div");
        static internal By writeSettingsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[15]/div/label/div");
        static internal By accountSettingsCheckbox = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[16]/div/label/div");

        //Sections Permissions
        static internal By sectionsPermissionsLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[4]/label");
        static internal By selectSectionItemPermissionsButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[4]/div/button");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.AreEqual(pageHeader, "Facility Role");
            VerifyElement.AreEqual(roleNameLabel, "Role Name");
            VerifyElement.IsPresent(roleNameTextField);
            VerifyElement.AreEqual(descriptionLabel, "Description");
            VerifyElement.IsPresent(descriptionTextField);
            VerifyElement.AreEqual(checkedUncheckedText, "Checked means Read/Write, unchecked means Read-Only");
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(saveButton);

            //Permissions
            VerifyElement.AreEqual(permissionsLabel, "Permissions");
            VerifyElement.IsPresent(readUsersCheckbox);
            VerifyElement.IsPresent(writeUsersCheckbox);
            VerifyElement.IsPresent(readAssessmentsCheckbox);
            VerifyElement.IsPresent(writeAssessmentsCheckbox);
            VerifyElement.IsPresent(manageAssessmentsCheckbox);
            VerifyElement.IsPresent(readResidentsCheckbox);
            VerifyElement.IsPresent(writeResidentsCheckbox);
            VerifyElement.IsPresent(readScheduleCheckbox);
            VerifyElement.IsPresent(writeScheduleCheckbox);
            VerifyElement.IsPresent(readBatchesCheckbox);
            VerifyElement.IsPresent(writeBatchesCheckbox);
            VerifyElement.IsPresent(readReportsCheckbox);
            VerifyElement.IsPresent(writeReportsCheckbox);
            VerifyElement.IsPresent(readSettingsCheckbox);
            VerifyElement.IsPresent(writeSettingsCheckbox);
            VerifyElement.IsPresent(accountSettingsCheckbox);

            //Sections Permissions
            VerifyElement.AreEqual(sectionsPermissionsLabel, "Sections Permissions");
            VerifyElement.IsPresent(selectSectionItemPermissionsButton);




            #endregion

            #region Navigation


            #endregion
        }
    }
}