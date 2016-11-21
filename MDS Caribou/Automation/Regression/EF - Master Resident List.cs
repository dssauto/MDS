using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EF___Master_Resident_List : BaseSetup
    {
        [Test]
        public void EF_Master_Resident_List()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Reports &Forms Tile.
            LandingPage.NavigateToReportsFormsPage();
            //Step 2  Select the Master Resdient List option from the left hand navigation bar.
            DashboardPage.NavigateToMDSMasterResidentList();
            //Step 3  Click the Create Report Button.
            Driver.ClickOn(MDSMasterResidentListPage.createReportButton);
            //Step 4  "Leave the default neighborhood <All Neighborhoods>.
            //Click the Confirm button."
            Driver.ClickOn(MDSMasterResidentListPage.confirmBtn);
            //Step 5  Verify Each Column for the report is displayed with information pertaining to a particular resident.
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: left;'][1]");
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: left;'][2]");
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: left;'][3]");
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: left;'][4]");
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: left;'][5]");
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: left;'][6]");
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: left;'][7]");
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: right;'][1]");
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: left;'][8]");
            MDSMasterResidentListPage.VerifyColumnList("//td[@style='text-align: left;'][9]");
            //Step 6  Verify If a neighborhood is not displayed that the Status of that resident is inactive.
            //Step 7  "Select 5 random residents from the list. 
            Driver.ClickOn(By.XPath("(//div[@class='dx-checkbox-container'])[1]"));
            //Open a VistA terminal window and follow the attached document to verify that the information displayed in the report is the same information that is displayed in VistA."
            //Step 8  "Select a column Header and drag it to the column grouping area. 
            //Verify that the report then sorts according to the header that was dragged to the column grouping area."
            //Step 9  "Drag the header back into the report. 
            //Verify the sorting of the report is back to its origional state."
            //Step 10 Click the Export button.
            //Step 11 Click the Excel File option.
            //Step 12 "Select Save.
            //Save the exported report to the local computer.
            //Once it has been saved opn the saved document."
            //Step 13 Verify the report matches what is displayed on the Caribou MDS website.
            //Step 14 Close the saved document and return to the Caribou MDS website where the Master Resdient list is displayed.
            //Step 15 "Click the Export button. 
            //Click the checkbox for selected rows. 
            //Select rows from the report by checking the checkbox withing the respective column for that resident. 
            //Click the Export button again.
            //Click the Excel File option.
            //Save the report to the local computer.
            //Once saved, open the report.
            //Verify the report matches what was selected previously to be displayed on the report."
            //Step 16 Close the saved document and return to the Caribou MDS website where the master resident list report is displayed.
            //Step 17 Click the Column Chooser button on the right side of the Master Resident Report.
            //Step 18 "Drag a column from the report into the column chooser dialog box. 
            //Verify that once the column is displayed in the column chooser dialog box, the column is then taken off of the report and hidden."
        }
    }
}
