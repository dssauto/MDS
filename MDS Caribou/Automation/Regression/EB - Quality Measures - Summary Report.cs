using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EB___Quality_Measures___Summary_Report
    {
        [Test]
        public void TestName()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  "Preconditions:  
            //1.Have a Long Stay(101 daays or greater) assessment already completed / Sealed / Batched with ""All Nos"" and nothing activated within the assesment. 
            //2.Have a Short Stay(100 days or less) assessment already completed / Sealed / Batched with ""All Nos"" and nothing activated within the assesment."
            //Step 2  Click the Batch and Transmit Tile
            //Step 3  Click the Batches Tile.
            //Step 4  Verify that the assessment from the precondition step is displayed in a batch with the "Transmission Status" as 'Batched'.
            //Step 5  "Click the User Icon in the upper Right hand corner of the Caribou MDS web application. 
            //Select the Reports and Forms option."
            //Step 6  Click the Quality Measures option from the left hand menu.
            //Step 7  Select the Summary option from the left hand menu.
            //Step 8  Verify the Date Selection default value is set to the last quarter (last 3 months).
            //Step 9  Select the Date Range text field.
            //Step 10 Select a 'To' and 'From' date range that the assessments ARD falls into.
            //Step 11 Click the Apply button.
            //Step 12 Take a screenshot(s) of the QM Summary report.
            //Step 13 "Click the user icon in the upper right hand corner of the Caribou MDS web application.
            //Select the Batch and Transmit option."
            //Step 14 Select the Batches Tile.
            //Step 15 On the assessments being used to test the summary report(Both Long Stay and Short Stay assessments), select the checkbox of the assessments within the batch.
            //Step 16 "Select the ""Update Status"" button for each. 
            //Select the Accepted option."
            //Step 17 Verify Transmission Status for each assessment is set to "Accepted".
            //Step 18 "Click the User Icon in the upper Right hand corner of the Caribou MDS web application. 
            //Select the Reports and Forms option."
            //Step 19 Click the Quality Measures option from the left hand menu.
            //Step 20 Select Summary option from the left hand menu.
            //Step 21 Verify the Date Selection default value is set to the last quarter(last 3 months).
            //Step 22 Select the Date Range text field.
            //Step 23 Select a 'To' and 'From' date range that the assessments ARD falls into.
            //Step 24 Click the Apply button.
            //Step 25 Using the screenshot previously taken, verify the values(without exclusions, see attached document) for Long Stay on the Summary report is increaded by 1.
            //Step 26 Short Stay Test
            //Step 27 "Click the user icon in the upper right hand corner of the Caribou MDS web application.
            //Select the Batch and Transmit option."
            //Step 28 Take a screenshot of all of the short stay items to be triggered.
            //Step 29 Select the Batches Tile.
            //Step 30 On the assessments being used to test the summary report(Both Long Stay and Short Stay assessments), select the checkbox of the assessments within the batch.
            //Step 31 "Select the ""Update Status"" button for each. 
            //Select the Transmitted option."
            //Step 32 Verify Transmission Status for each assessment is set to "Transmitted".
            //Step 33 "Click the User icon in the upper right corner of the Caribou MDS web application. 
            //Select the Resident History.
            //Enter the Residents Name in the Search Box.
            //Click the Residents Tile.
            //Select the radio button for the assessment.
            //Click the History Action Dropdown menu.
            //Select UnSeal. (Select Yes to the Prompt)
            //Record is now unsealed.
            //Click the Action Dropdown Menu again.
            //Select Unsign / Edit.
            //Enter users password, select OK.
            //Click the Action Dropdown menu once more.
            //Select Edit."
            //Step 34 With the Screen shot noted previously for the Short Stay triggers, go through the assessmrnt and enter each trigger into the assessment.
            //Step 35 "Once the triggers are answered in the assessment:
            //Sign and Seal the assessment(Section Z / V).
            //Click the user icon in the upper right hand corner of the Caribou MDS application.Select the Batch and Transmit tile.
            //Click the Assessment Tile.
            //The Signed and Sealed assessment will be displayed, (If not move the day slider bar out to max 370 days).
            //Click the Checkbox to the Sealed assessment, and click the Create Batch button in the upper right corner of the Caribou MDS web application. 
            //Dialog will be displayed showing the assessment.Click the Create button. 
            //Batch is created and batch information is displayed.Click the close button."
            //Step 36 "Click the breadcrumb in the upper left corner Caribou MDS web application back to the previous page (Batches Page).
            //CLick the Batches Tile. 
            //Select the checkbox for the assessment.
            //Select the Status button, and select the ""Accepted"" status."
            //Step 37 "Click the User Icon in the upper right hand corner of the Caribou MDS web pplication.
            //Selet the Reports and Forms option.
            //Select the Quality Measures option from the left hand navigation pane.
            //When the dropdown is displayed Select the Summary option."
            //Step 38 Select the Date Range text field.
            //Step 39 Select a 'To' and 'From' date range that the assessments ARD falls into.
            //Step 40 Click the Apply button.
            //Step 41 "Verify that all of the Short Stay measures triggered previously have increased by 1 on the Summary report. 
            //NOTE: If they have not triggered, check the exclusion for that requirement and be sure it has not been excluded."
            //Step 58 For this step, using the attachment, test all senarios in the document. Once all have passed, this step shall pass.
            //Step 42 Long Stay Test
            //Step 43 "Click the user icon in the upper right hand corner of the Caribou MDS web application.
            //Select the Batch and Transmit option."
            //Step 44 Take a screenshot of all of the long stay items to be triggered in the report.
            //Step 45 Select the Batches Tile.
            //Step 46 On the assessments being used to test the summary report(Both Long Stay and Short Stay assessments), select the checkbox of the assessments within the batch.
            //Step 47 "Select the ""Update Status"" button for each. 
            //Select the Transmitted option."
            //Step 48 Verify Transmission Status for each assessment is set to "Transmitted".
            //Step 49 "Click the User icon in the upper right corner of the Caribou MDS web application. 
            //Select the Resident History.
            //Enter the Residents Name in the Search Box.
            //Click the Residents Tile.
            //Select the radio button for the assessment.
            //Click the History Action Dropdown menu.
            //Select UnSeal. (Select Yes to the Prompt)
            //Record is now unsealed.
            //Click the Action Dropdown Menu again.
            //Select Unsign / Edit.
            //Enter users password, select OK.
            //Click the Action Dropdown menu once more.
            //Select Edit."
            //Step 50 With the Screen shot noted previously for the long Stay triggers, go through the assessmrnt and enter each trigger into the assessment.
            //Step 51 "Once the triggers are answered in the assessment:
            //Sign and Seal the assessment(Section Z / V).
            //Click the user icon in the upper right hand corner of the Caribou MDS application.Select the Batch and Transmit tile.
            //Click the Assessment Tile.
            //The Signed and Sealed assessment will be displayed, (If not move the day slider bar out to max 370 days).
            //Click the Checkbox to the Sealed assessment, and click the Create Batch button in the upper right corner of the Caribou MDS web application. 
            //Dialog will be displayed showing the assessment.Click the Create button. 
            //Batch is created and batch information is displayed.Click the close button."
            //Step 52 "Click the breadcrumb in the upper left corner Caribou MDS web application back to the previous page (Batches Page).
            //CLick the Batches Tile. 
            //Select the checkbox for the assessment.
            //Select the Status button, and select the ""Accepted"" status."
            //Step 53 "Click the User Icon in the upper right hand corner of the Caribou MDS web pplication.
            //Selet the Reports and Forms option.
            //Select the Quality Measures option from the left hand navigation pane.
            //When the dropdown is displayed Select the Summary option."
            //Step 55 Select the Date Range text field.
            //Step 56 Select a 'To' and 'From' date range that the assessments ARD falls into.
            //Step 57 Click the Apply button.
            //Step 58 "Verify that all of the Short Stay measures triggered previously have increased by 1 on the Summary report. 
            //NOTE: If they have not triggered, check the exclusion for that requirement and be sure it has not been excluded."
            //Step 59 For this step, using the attachment, test all senarios in the document. Once all have passed, this step shall pass.

        }
    }
}
