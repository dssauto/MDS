using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class FB___RUG_Scores
    {
        [Test]
        public void FB_Assessment_RUG_Scores()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Click the Schedule Tile.
            //Step 2  Enter the name of the resident to create an admission assessment on in the Search text box.
            //Step 3  Select the resident name from the dropdown menu.
            //Step 4  On the line item for the Admission assessment click the "Create Assessment" button.
            //Step 5  Select the correct coding for an NC item set.
                      //The NC item set coding is as follows:
                      //1.
                      //99.
                      //0.
                      //99.
            //Step 6  Click the "Create" button.
            //Step 7  Select Section G from the left side menu.
            //Step 8  Scroll to G0110 A - Bed mobility.
                      //Column 1.enter 3 Extreme assistance.
                      //Column 2.enter 3 Two + person physical assistance.
            //Step 9  G0110 B - Transfer
                      //Column 1.enter 3 Extreme assistance.
                      //Column 2.enter 3 Two + physical assist. 
            //Step 10 G0110 H - Eating
                      //Column 1.enter 3 Extreme assistance.
                      //Column 2.One person physical assist.
            //Step 11 G0110 I - Toilet use
                      //Column 1.enter 3 Extreme assistance.
                      //Column 2.enter 3 Two + person physical assist.
            //Step 12 Click Save in the bottom right of the page.
            //Step 13 Select Section O from left side menu.
            //Step 14 Scroll to O0100 F - Ventilator or respirator.
                      //Check: Column 1.While NOT a Resident.
                      //Check: Column 2.While a Resident.
            //Step 15 Scroll to O0400 A - Speech-Language Pathology and Audiology Services. 
                      //1.Individual minutes - enter 225.
                      //2.Concurrent minutes - enter 50.
                      //3.Group minutes - enter 60.
                      //3A.Co - treatment minutes - enter 0.
                      //4.Days - enter 5.
                      //5.Therapy start date - enter date based on admit date.
                      //6.Therapy end date - enter dash.
            //Step 16 O0400 B - Occupational Therapy. 
                      //1.Individual minutes - enter 300.
                      //2.Concurrent minutes - enter 60.
                      //3.Group minutes - enter 60.
                      //3A.Co - treatment minutes - enter 0.
                      //4.Days - enter 3.
                      //5.Therapy start date - enter date based on admit date.
                      //6.Therapy end date - enter dashes.
            //Step 17 O0400 C - Physical Therapy.
                      //1.Individual minutes - enter 150.
                      //2.Concurrent minutes - enter 50.
                      //3.Group minutes - enter 100.
                      //3A.Co - treatment minutes - enter 0.
                      //4.Days - enter 4.
                      //5.Therapy start date - enter date based on admit date.
                      //6.Therapy end date - enter dashes.
            //Step 18 O0400 D - Respiratory Therapy.
                      //2.Days - enter 0.
                      //O0400 E.Psychological Therapy.
                      //2.Days - enter 0.
            //Step 19 O0420 Distinct Callendar Days of Therapy.
                      //Enter 7.
            //Step 20 Click Save in the bottom right of the page.
            //Step 21 Select section Z from left side menu.
            //Step 22 Verify Z0100 sub question A.Medicare Part A HIPPS code text box is populated with a RUX10
            //Step 23 Verify Z0100 sub Question B RUG Version Code text box is populated with 1.0366.
            //Step 24 Verify Z0150 sub question A.Medicare Part A non - therapy HIPPS code text box is populated with ES210
            //Step 25 Verify Z0150 Sub question B.RUG Version Code is populated with 1.0366
            //Step 26 Verify Z0200 State Medicaid Billing sub question A.RUG Case Mix Group text box is populated with RUX.
            //Step 27 Verify Z0200 State Medical Billing  Sub question B.RUG Version Code is populated with 1.0366.
            //Step 28 Verify Z0250 Alternate State Medicaid Billing sub question A.RUG Case Mix Group text box is populated with RUX
            //Step 29 Verify Z0250 Alternate State Medical Billing Sub question B.RUG Version Code is populated with 1.0366.
            //Step 30 Click Section O in the left hand navigation menu.
            //Step 31 Scroll down to question O0400.Therapies.
            //Step 32 Change the minutes in O0400 A.Speech - Language Pathology and Auditory Services sub question 1.Individual Minutes that was previously entered to 0.
            //Step 33 Change the minutes in O0400.B Occupational Therapy sub question 1.Individual Minutes, to 0.
            //Step 34 Click Save in the bottom right of the page.
            //Step 35 Click Section Z in the left hand navigation menu.
            //Step 36 Verify Z0100 sub question A.Medicare Part A HIPPS code text box has now changed from RUX66 to RMX10.
            //Step 37 Verify Z0150 sub question A.Medicare Part A non - therapy HIPPS code text has remained the same " ES210"
            //Step 38 Verify Z0200 State Medicaid Billing sub question A.RUG Case Mix Group text box has changed from RUX to  RMX.
            //Step 39 Verify Z0250 Alternate State Medicaid Billing sub question A.RUG Case Mix Group text box has changed to RMX.
            //Step 40 Click the breadcrumb Caribou CLC Suite in the top left corner of the page.
            //Step 41 Click the Work In Progress Tile.
            //Step 42 Choose a resident with an PPS assessment for the creation of an RUC RUG score.
                      //Select Radio button for assesment due and click Work In Progress button.
            //Step 43 Select Section G from the left side menu.
            //Step 44 Scroll to G0110 A - Bed mobility.
                      //Column 1.enter 3 Extreme assistance.
                      //Column 2.enter 3 Two + person physical assistance.
            //Step 45 G0110 B - Transfer
                      //Column 1.enter 3 Extreme assistance.
                      //Column 2.enter 3 Two + physical assist.
            //Step 46 G0110 H - Eating
                      //Column 1.enter 3 Extreme assistance.
                      //Column 2.One person physical assist.
            //Step 47 G0110 I - Toilet use
                      //Column 1.enter 3 Extreme assistance.
                      //Column 2.enter 3 Two + person physical assist.
            //Step 48 Click Save in the bottom right of the page.
            //Step 49 Select Section O from left side menu.
            //Step 50 Scroll to O0400 A - Speech-Language Pathology and Audiology Services. 
                      //1.Individual minutes - enter 225.
                      //2.Concurrent minutes - enter 50.
                      //3.Group minutes - enter 60.
                      //3A.Co - treatment minutes - enter 0.
                      //4.Days - enter 5.
                      //5.Therapy start date - enter date based on admit date.
                      //6.Therapy end date - enter dashes.
            //Step 51 O0400 B - Occupational Therapy. 
                      //1.Individual minutes - enter 300.
                      //2.Concurrent minutes - enter 60.
                      //3.Group minutes - enter 60.
                      //3A.Co - treatment minutes - enter 0.
                      //4.Days - enter 3.
                      //5.Therapy start date - enter date based on admit date.
                      //6.Therapy end date - enter dashes.
            //Step 52 O0400 C - Physical Therapy.
                      //1.Individual minutes - enter 150.
                      //2.Concurrent minutes - enter 50.
                      //3.Group minutes - enter 100.
                      //3A.Co - treatment minutes - enter 0.
                      //4.Days - enter 1.
                      //5.Therapy start date - enter date based on admit date.
                      //6.Therapy end date - enter dashes."
            //Step 53 O0400 D - Respiratory Therapy.
                      //2.Days - enter 0.
                      //O0400 E - Psychological Therapy
                      //2.Days - enter 0.
            //Step 54 O0420 Distinct Calendar Days of Therapy.
                      //Enter 7.
            //Step 55 Click Save in the bottom right of the page.
            //Step 56 Select section Z from left side menu.
            //Step 57 Verify Z0100 sub question A.Medicare Part A HIPPS code text box is populated with a RUC10
            //Step 58 Verify Z0100 sub Question B RUG Version Code text box is populated with 1.0366.
            //Step 59 Verify Z0150 sub question A.Medicare Part A non - therapy HIPPS code text box is populated with PE110
            //Step 60 Verify Z0150 Sub question B.RUG Version Code is populated with  1.0366.
            //Step 61 Verify Z0200 State Medicaid Billing sub question A.RUG Case Mix Group text box is populated with RUC.
            //Step 62 Verify Z0200 State Medical Billing  Sub question B.RUG Version Code is populated with  1.0366.
            //Step 63 Verify Z0250 Alternate State Medicaid Billing sub question A.RUG Case Mix Group text box is populated with PE1
            //Step 64 Verify Z0200 Alternate State Medical Billing Sub question B.RUG Version Code is populated with  1.0366
            //Step 65 Click Section O in the left hand navigation menu.
            //Step 66 Scroll down to question O0400.Therapies.
            //Step 67 Change the minutes in O0400 A.Speech - Language Pathology and Auditory Services sub question 1.Individual Minutes that was previously entered to 0.
            //Step 68 Change the minutes in O0400.B Occupational Therapy sub question 1.Individual Minutes, to 0.
            //Step 69 Click Save in the bottom right of the page.
            //Step 70 Click Section Z in the left hand navigation menu.
            //Step 71 Verify Z0100 sub question A.Medicare Part A HIPPS code text box has now changed from RUC to RMC.
            //Step 72 Verify Z0150 sub question A.Medicare Part A non - therapy HIPPS code text has remained the same at PE1.
            //Step 73 Verify Z0200 State Medicaid Billing sub question A.RUG Case Mix Group text box has changed from RUC TO RMC.
            //Step 74 Verify Z0250 Alternate State Medicaid Billing sub question A.RUG Case Mix Group text box has remained the same at PE1.
        }
    }
}