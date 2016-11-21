using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EN___Facility_Settings___CAA_Setting : BaseSetup
    {
        string admissionOpenWIP = "(//span[@class='label ng-binding ng-scope'][contains(., 'Admission')]//ancestor::div[1]//parent::div[1]//parent::div//button[@class='btn btn-wip pull-right ng-scope'])[1]";

        [Test]
        public void EN_Facility_Settings_CAA_Setting()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Log in as Facility Administrator.
            //Step 2  Click Admin tile.
            LandingPage.NavigateToAdminPage();
            //Step 3  Click Facility Settings in the left hand menu.
            AdminPage.NavigateToFacilitySettings();
            //Step 4  "Care Areas
            //      Check box with Use Care Area Assessments?
            //      Verify check box is checked signifying Care 
            //      Area Assessments are turned on."
            if (Driver.IsElementPresent(By.XPath("(//input[@aria-checked='true'])[1]//ancestor::label[contains(., 'Use Care Area')]")))
            {
                Driver.ClickOn(FacilitySettingsPage.saveButton);
            }
            else
            {
                Driver.ClickOn(By.XPath("//div[@class='icheckbox_square-blue']"));
                Driver.ClickOn(FacilitySettingsPage.saveButton);
            }
            //Step 5  Click SAVE button.
            //Step 6  Click the breadcrumb "Caribou CLC Suite"
            Driver.ClickOn(UserMenu.userIcon);
            //Step 7  Click Work In Progress Tile.
            Driver.ClickOn(UserMenu.wipIcon);
            //Step 8  "Select a resident with a comprehensive assessment (Admission or Annual).
            Driver.ClickOn(WorkInProgressPage.ppsFilterButtonChecked);
            if (Driver.IsElementPresent(By.XPath(admissionOpenWIP)))
            {
                Driver.ClickOn(By.XPath(admissionOpenWIP));
            }
            else
            {
                Driver.ClickOn(SchedulePage.twoPagination);
                Driver.ClickOn(By.XPath(admissionOpenWIP));
            }
            //Click OPEN WIP button to the right of the Assessment to be opened."
            //Step 9  Click Section V in the left hand menu.
            //Step 10 "Scroll to V0200. CAAs and Care Planning
            //A.CAA Results"
            //Step 11 Verify Details column displays CAA buttons signifying that the Care Area Assessments are active.
            Driver.WaitFor(4);
            Browser.ScrollToElement("//*[@id='sectionv-content']/div[10]/div/div/div[1]/button");
            VerifyElement.IsPresent(By.XPath("(//button[@uib-tooltip='Delirium Assessment'])[1]"));
            //Step 12 Click Cancel.
            //Step 13 Click the breadcrumb "Caribou CLC Suite"
            Driver.ClickOn(UserMenu.caribouCLCSuiteLink);
            //Step 14 Click Admin tile.
            LandingPage.NavigateToAdminPage();
            //Step 15 Click Facility Settings in the left hand menu.
            AdminPage.NavigateToFacilitySettings();
            //Step 16 "Care Areas
            //Uncheck check box for Use Care Area Assessments signifying Care Area Assessments are turned off."
            Driver.ClickOn(By.XPath("(//input[@aria-checked='true'])[1]//ancestor::label[contains(., 'Use Care Area')]"));
            //Step 17 Click SAVE button.
            Driver.ClickOn(FacilitySettingsPage.saveButton);
            //Step 18 Click the breadcrumb "Caribou CLC Suite"
            Driver.ClickOn(UserMenu.userIcon);
            //Step 19 Click Work In Progress tile.
            Driver.ClickOn(UserMenu.wipIcon);
            //Step 20 "Select a resident with a comprehensive  assessment (Admission or Annual).
            //Click OPEN WIP button to the right of the Assessment to be opened."
            Driver.ClickOn(WorkInProgressPage.ppsFilterButtonChecked);
            if (Driver.IsElementPresent(By.XPath(admissionOpenWIP)))
            {
                Driver.ClickOn(By.XPath(admissionOpenWIP));
            }
            else
            {
                Driver.ClickOn(SchedulePage.twoPagination);
                Driver.ClickOn(By.XPath(admissionOpenWIP));
            }
            //Step 21 Click Section V.
            Driver.ClickOn(By.XPath("//a[contains(., 'Section V')]"));
            //Step 22  Click Section V in the left hand menu.
            //Step 23 "Scroll to V0200. CAAs and Care Planning
            //A.CAA Results"
            Driver.WaitFor(4);
            Browser.ScrollToElement("//*[@id='sectionv-content']/div[10]/div/div/div[1]/button");
            //Step 24 Verify that Details column does not exist.
            VerifyElement.IsNotPresent(By.XPath("(//button[@uib-tooltip='Delirium Assessment'])[1]"));
            //Step 25 Click the breadcrumb "Caribou CLC Suite"
            Driver.ClickOn(UserMenu.userIcon);
            Driver.ClickOn(UserMenu.signoutButton);
        }
    }
}
