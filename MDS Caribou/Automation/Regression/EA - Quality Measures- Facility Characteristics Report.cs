using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EA_Quality_Measures__Facility_Characteristics_Report: BaseSetup
    {
        [Test]
        public void EA_Quality_Measures_Facility_Characteristics_Report()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Preconditions:
                      //1.Have an assessment that DOES NOT have Discharge Plan (Q0400), Referral(Q0600), Type Of Entry(A1700).Entered Facility From(A1800) Prognosis(J1400) and Diagnostic Characteristics(A1500 - A1550) filled out.
                      //2.Have an assessment already completed / Sealed / Batched and accepted with ""All Nos"" and nothing activated within the assesment.
            //Step 2  Click the Batch and Transmit Tile
            //Step 3  Click the Batches Tile.
            //Step 4  Verify that the assessment from the precondition step is displayed in a batch with the "Transmission Status" as 'Batched'.
            //Step 5  Click the User Icon in the upper Right hand corner of the Caribou MDS web application. 
                      //Select the Reports and Forms option.
            //Step 6  Click the Quality Measures option from the left hand menu.
            //Step 7  Select the Facility Characteristics option from the left hand menu.
            //Step 8  Verify the Date Selection default value is set to the last quarter(last 3 months).
            //Step 9  Select the Date Range text field.
            //Step 10 Select a 'To' and 'From' date range that the assessments ARD falls into.
            //Step 11 Click the Apply button.
            //Step 12 Note the Values on the Facility Characteristics report via screenshot. 
                      //NOTE: This is becasue an assessment must be in ""Accepted"" status to be counted on the report.
            //Step 13 Click the user icon in the upper right hand corner of the Caribou MDS web application.
                      //Select the Batch and Transmit option.
            //Step 14 Select the Batches Tile.
            //Step 15 On the assessment and batch that has the QM triggers, select the checkbox of the assessment within the batch.
            //Step 16 Select the "Update Status" button. 
                      //Select Accepted.
            //Step 17 Verify Transmission Status for that assessment is set to "Accepted".
            //Step 18 Click the User Icon in the upper Right hand corner of the Caribou MDS web application. 
                      //Select the Reports and Forms option.
            //Step 19 Click the Quality Measures option from the left hand menu.
            //Step 20 Select the Facility Characteristics option from the left hand menu.
            //Step 21 Verify the Date Selection default value is set to the last quarter(last 3 months).
            //Step 22 Select the Date Range text field.
            //Step 23 Select a 'To' and 'From' date range that the assessments ARD falls into.
            //Step 24 Click the Apply button.
            //Step 25 Using the screenshot previously taken, verify the values on the Fac Char report is increaded by 1.
            //Step 26 Take a Screenshot, or multiple screenshots, of the Fac Char report with its values displayed.
            //Step 27 Click the User Icon in the upper right corner of the Caribou MDS Web application.
                      //Click the History option.
            //Step 28 Enter in the Residents name into the Search Residents text Box of the assessment that was set to accepted status.
            //Step 29 Select the resident tile.
            //Step 30 Selec tthe Radio button of the Accepted assessment. 
                      //Click the Action History Dropdown Menu.
                      //Select View.
            //Step 31 Verify against the screenshot taken in previous steps of the report that all answers in the assessment match that of what is on the report screenshot.
                      //Answers include: 
                      //A0800 Gender - SHOULD BE Num 1(whatever age the resident is) Denom 1
                      //A0900 Age - SHOULD BE Num 1(whatever gender the resident is) Denom 1
                      //A1500 - A1550 Diagnostic Characteristics - SHOULD BE Num 0 Denom 1
                      //J1400 - Prognosis. - SHOULD BE Num 0 Denom 1
                      //Q0400 - Discharge Plan. - SHOULD BE Num 0 Denom 1
                      //Q0600 - Referral. - SHOULD BE Num 0 Denom 1
                      //A1700 - Type Of Entry - SHOULD BE Num 0 Denom 1
                      //A1800 - Entered Facility From - SHOULD BE Num 0 Denom 1"
            //Step 32 Verify Each of the following triggers are checked and verified step by step, one by one WITH EXCLUSIONS to finish verifying the entire report. 
                      //A1500 - A1550 Diagnostic Characteristics
                      //I5200 - I6100 - Psychiatric Diagnosis
                      //A1500 / A1510 - Intellectual or Developmental Disability
                      //O0100K2 - Hospice
                      //J1400 - Prognosis.
                      //Q0400 - Discharge Plan.
                      //Q0600 - Referral.
                      //A1700 - Type Of Entry
                      //A1800 - Entered Facility From
            //For the QM Requirements for these sections, see attached document.This is tested off of version 9 QM manual.
        }
    }
}
