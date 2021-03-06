﻿using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EC___Detail___Long_Stay
    {
        [Test]
        public void EC_Detail___Long_Stay()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Preconditions:  
                      //1.Have a Long Stay(101 daays or greater) assessment already completed / Sealed / Batched with "All Nos" and nothing activated within the assesment.
            //Step 2  Click the Batch and Transmit Tile
            //Step 3  Click the Batches Tile.
            //Step 4  Verify that the assessment from the precondition step is displayed in a batch with the "Transmission Status" as 'Batched'.
            //Step 5  Click the User Icon in the upper Right hand corner of the Caribou MDS web application. 
                      //Select the Reports and Forms option.
            //Step 6  Click the Quality Measures option from the left hand menu.
            //Step 7  Select the Detail - Long Stay option from the left hand menu.
            //Step 8  Verify the Date Selection default value is set to the last quarter (last 3 months).
            //Step 9  Select the Date Range text field.
            //Step 10 Select a 'To' and 'From' date range that the assessments ARD falls into.
            //Step 11 Click the Apply button.
            //Step 12 Verify that the Resident is NOT displayed on the report.
            //Step 13 Take a screenshot(s) of the Long Stay report.
            //Step 14 Click the user icon in the upper right hand corner of the Caribou MDS web application.
                      //Select the Batch and Transmit option.
            //Step 15 Select the Batches Tile.
            //Step 16 On the assessment being used to test the Long Stay report select the checkbox of the assessment within the batch.
            //Step 17 Select the "Update Status" button.. 
                      //Select the Accepted option.
            //Step 18 Verify Transmission Status is set to "Accepted".
            //Step 19 Click the User Icon in the upper Right hand corner of the Caribou MDS web application. 
                      //Select the Reports and Forms option.
            //Step 20 Click the Quality Measures option from the left hand menu.
            //Step 21 Select Detail -Long Stay option from the left hand menu.
            //Step 22 Select the Date Range text field.
            //Step 23 Select a 'To' and 'From' date range that the assessments ARD falls into.
            //Step 24 Click the Apply button.
            //Step 25 Verify the Resident is displayed on the report BUT nothing is displayed on the resident as there is no data triggered in the assessment.
            //Step 26 Take a screenshot of all of the Long Stay items to be triggered.
            //Step 27 Click the user icon in the upper right hand corner of the Caribou MDS web application.
                      //Select the Batch and Transmit option.
            //Step 28 Select the Batches Tile.
            //Step 29 On the assessment being used to test the Long Stay Detail Report select the checkbox in the batch for that assessment.
            //Step 30 Select the "Update Status" button. 
                      //Select the Transmitted option."
            //Step 31 Verify Transmission Status is set to "Transmitted".
            //Step 32 Click the User icon in the upper right corner of the Caribou MDS web application. 
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
                      //Select Edit.
            //Step 33 With the Screen shot noted previously for the Long Stay triggers, go through the assessmrnt and enter each trigger into the assessment.
            //Step 34 Once the triggers are answered in the assessment:
                      //Sign and Seal the assessment(Section Z / V).
                      //Click the user icon in the upper right hand corner of the Caribou MDS application.Select the Batch and Transmit tile.
                      //Click the Assessment Tile.
                      //The Signed and Sealed assessment will be displayed, (If not move the day slider bar out to max 370 days).
                      //Click the Checkbox to the Sealed assessment, and click the Create Batch button in the upper right corner of the Caribou MDS web application. 
                      //Dialog will be displayed showing the assessment.Click the Create button. 
                      //Batch is created and batch information is displayed.Click the close button.
            //Step 35 Click the breadcrumb in the upper left corner Caribou MDS web application back to the previous page (Batches Page).
                      //CLick the Batches Tile. 
                      //Select the checkbox for the assessment.
                      //Select the Status button, and select the "Accepted"" status.
            //Step 36 Click the User Icon in the upper right hand corner of the Caribou MDS web pplication.
                      //Selet the Reports and Forms option.
                      //Select the Quality Measures option from the left hand navigation pane.
                      //When the dropdown is displayed Select the Detail - Long Stay option.
            //Step 37 Select the Date Range text field.
            //Step 38 Select a 'To' and 'From' date range that the assessments ARD falls into.
            //Step 39 Click the Apply button.
            //Step 40 Verify that all of the Long Stay measures triggered previously have increased by 1 on the Summary report. 
                      //NOTE: If they have not triggered, check the exclusion for that requirement and be sure it has not been excluded.
            //Step 41 For this step, using the attachment, test all senarios in the document. Once all have passed, this step shall pass.
        }
    }
}