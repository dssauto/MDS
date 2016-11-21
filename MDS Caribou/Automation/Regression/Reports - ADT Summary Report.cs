using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class Reports___ADT_Summary_Report
    {
        [Test]
        public void Reports_ADT_Summary_Report()
        {
            Browser.Open();
            LoginPage.SignIn();
            //CPRS Required
            //Step 1  Select the Reports and Forms Tile.
            //Step 2  While in the Reports and Forms Tile with the Dashboard menu option selected, scroll to the bottom of the dashboard page and select the ADT Report Summary button.
            //Step 3  Select the Date selection button on the ADT Report.
            //Step 4  "In the ""From"" calendar, select a From Date that is 4 days prior to todays date. 
                      //Example: is todays date is 8 / 23 / 2016 the user would select 8 / 19 / 2016 in the ""From"" Calendar."
            //Step 5  In the "To" calendar, select todays Date if not already selected.
            //Step 6  Click the Apply Button.
            //Step 7  "Note 1 resident from the admissions section, and Note the Date / Time of admission, resident name, and the Neighborhood theyre located in. 
                      //Note 1 resident from the Discharges section, and Note the Date / Time of admission, resident name, and the Neighborhood theyre located in. 
                      //Note 1 resident from the Transfers section, and Note the Date / Time of admission, resident name, and the Neighborhood theyre located in."
            //Step 8  "Open CPRS from the local computer desktop icon. 
            //Select appropriate server, click the OK button.
            //Enter Access / Verify codes for the Coordinator User, click OK."
            //Step 9  "Enter the resident name from the admissions section noted previously into the patient selection search box. 
            //Select the Resident from the populated list.
            //Click the OK button on the top right of the Patient Selection dialog box."
            //Step 10 Select the Resident Name button in the top left corner of CPRS.
            //Step 11 "In the middle of the Patient Inquery dialog Verify the following: 
            //Admitted date is the same as noted previously in the ADT Report summary.
            //Ward / Neighborhood is the same as noted previously in the ADT Report summary."
            //Step 12 Click the Close button o the Resident Inquery dialog.
            //Step 13 Select File > Select New Patient from the top menu bar.
            //Step 14 "Enter the name of the Transferred resident noted previously in the Patient Selection search box
            //Select the Resident Name from the populated list.
            //Click the OK button in the top right corner of the Patient Selection dialog."
            //Step 15 Select the Resident Name button in the top left corner of CPRS.
            //Step 16 "In the middle of the Patient Inquery dialog Verify the following: 
            //Transfered date is the same as noted previously in the ADT Report summary.
            //Ward / Neighborhood is the same as noted previously in the ADT Report summary."
            //Step 17 Click the Close button on the Resident Inquery dialog.
            //Step 18 Select File > Select New Patient from the top menu bar.
            //Step 19 "Enter the name of the Discharged resident noted previously in the Patient Selection search box
            //Select the Resident Name from the populated list.
            //Click the OK button in the top right corner of the Patient Selection dialog."
            //Step 20 Select the Resident Name button in the top left corner of CPRS.
            //Step 21 "In the middle of the Patient Inquery dialog Verify the following: 
            //Discharge date is the same as noted previously in the ADT Report summary.
            //Ward / Neighborhood is the same as noted previously in the ADT Report summary."

        }
    }
}
