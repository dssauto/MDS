using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EL___Episode_File_All_3_scenarios
    {
        [Test]
        public void EL_Episode_File_All_3_scenarios()
        {
            Browser.Open();
            LoginPage.SignIn();
            //VistA Required
            //Step 1  "Precondition:
                      //1.Have 3 preselected residents that are Active, and have admission dates at least 3 months prior to the testing date."
            //Step 2  //"Open 2 VistA Terminal Windows via the cache cube. 
                      //Select appropriate server.
                      //PLEASE NOTE WHICH WINDOW IS FOR WHICH PURPOSE. 
                      //1st window will be for Discharging and Admitting residents.
                      //2nd window will be for checking the episode file."
            //Step 3  "Open the Caribou MDS website. 
                      //Login to Caribou.
                      //Click the Schedule tile."
            //Step 4  "Senario 1 
                      //Discharge - Return Anticipated - Readmit within 30 days"
            //Step 5  "Using the 2nd terminal window follow the attached document and check the episode file for the first resident. 
                      //Take a screenshot of the episode file for the first resident.
                      //Verify the Episode status is Active."
            //Step 6  Using the First terminal window, follow the attached document and discharge the resident.
            //Step 7  "Open the Caribou MDS website that is on the schedule page. 
                      //If the user has timed out -Enter the passwordand click login - "
            //Step 8  "Enter the name of the resident that was discharged in the search residents text box on the schedule page. 
                      //Verify that the Discharge assessment is displayed.
                      //NOTE: If the old schedule is displayed, please Sync and then refresh the page to display the discharge assessment."
            //Step 9  Click the "Create MDS" button on the discharge assessment line item.
            //Step 10 "Enter the coding for the Discharge Return Anticipated. 
                       //The coding is as follows: 
                       //99.
                       //99.
                       //0.
                       //11. < ---Return Anticipated
                       //Click the Create MDS button on the bottom of the Create MDS dialog."
           //Step 11  Using the second VistA window and the attached document.check the episode file and verify that the Discharge Status of the resident is "Return Anticipated.
           //Step 12  Using the first terminal window and using the attached document re-admit the resident within 30 days.
           //Step 13  "Using the second terminal window and the attached document verify the following:
                      //- The episode file DID NOT create a second entry
                      //- The episode file is active.
                      //- The new admission date is displayed on the Episode file. 
                      //- The original admission and discharge are displayed as movement report pointers. 
                      //Verify the following on the Schedule: 
                      //-The schedule for this resident is still based on the original admission date, NOT the new admission date."
           //Step 14  "Senario 2 
                      //Discharge - Return Anticipated - Readmit at 31 days"
           //Step 15  "Using the 2nd terminal window follow the attached document and check the episode file for the second resident. 
                      //Take a screenshot of the episode file for the second resident.
                      //Verify the Episode status is Active."
           //Step 16  Using the First terminal window, follow the attached document and discharge the resident.
           //Step 17  "Open the Caribou MDS website that is on the schedule page. 
                      //If the user has timed out -Enter the passwordand click login - "
           //Step 18  "Enter the name of the resident that was discharged in the search residents text box on the schedule page. 
                      //Verify that the Discharge assessment is displayed.
                      //NOTE: If the old schedule is displayed, please Sync and then refresh the page to display the discharge assessment."
           //Step 19  Click the "Create MDS" button on the discharge assessment line item.
           //Step 20  "Enter the coding for the Discharge Return Anticipated. 
                      //The coding is as follows: 
                      //99.
                      //99.
                      //0.
                      //11. < ---Return Anticipated
                      //Click the Create MDS button on the bottom of the Create MDS dialog."
           //Step 21  Using the 2nd terminal window and the attached document.check the episode file and verify that the Discharge Status of the resident is "Return Anticipated.
           //Step 22  Using the first terminal window and using the attached document re-admit the resident at 31 days.
           //Step 23  "Using the second terminal window and the attached document verify the following:
                      //- A second episode file was created.
                      //- The first episode file status is Complete.
                      //- The second new episode file is active.
                      //- The old admission and discharge date are displayed on the Completed episode file.
                      //- The new admission date is displayed in the new episode file that is active."
           //Step 24  "Senario 3
                      //Discharge - Return NOT Anticipated -readmit before 30 days"
           //Step 25  "Using the 2nd terminal window follow the attached document and check the episode file for the third resident. 
                      //Take a screenshot of the episode file for the third resident.
                      //Verify the Episode status is Active."
           //Step 26  Using the First terminal window, follow the attached document and discharge the resident.
           //Step 27  "Open the Caribou MDS website that is on the schedule page. 
                      //If the user has timed out -Enter the passwordand click login - "
           //Step 28  "Enter the name of the resident that was discharged in the search residents text box on the schedule page. 
                      //Verify that the Discharge assessment is displayed.
                      //NOTE: If the old schedule is displayed, please Sync and then refresh the page to display the discharge assessment."
           //Step 29  Click the "Create MDS" button on the discharge assessment line item.
           //Step 30  "Enter the coding for the Discharge Return NOT Anticipated. 
                      //The coding is as follows: 
                      //99.
                      //99.
                      //0.
                      //12. < ---Return NOT Anticipated
                      //Click the Create MDS button on the bottom of the Create MDS dialog."
           //Step 31  Using the 2nd terminal window and the attached document.check the episode file and verify that the Discharge Status of the resident is "Return NOT Anticipated.
           //Step 32  Using the first terminal window and using the attached document re-admit the resident within 30 days.
           //Step 33  "Using the second terminal window and the attached document verify the following in the episode file:
                      //- A second episode file was created.
                      //- The first episode file status is Complete.
                      //- The second new episode file is active.
                      //- The old admission and discharge date are displayed on the Completed episode file.
                      //-The new admission date is displayed in the new episode file that is active.
                      //Verify the following on the Schedule:
                      //-The schedule for this resident is still based on the original admission date, NOT the new admission date."
        }
    }
}
