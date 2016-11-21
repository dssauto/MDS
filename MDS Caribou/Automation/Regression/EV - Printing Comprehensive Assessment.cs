using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Automation.Regression
{
    [TestFixture]
    class EV_Assessment___Validate_Printing_Comprehensive_Assessment
    {
        [Test]
        public void EV_Assessment_Validate_Printing_Comprehensive_Assessment()
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
            //Step 7  Click the Action Dropndown menu on the Assessment Overview page. 
                      //Select Print.
            //Step 8  Verify the Header is displayed on the print preview. 
                      //Verify the Resident Name, Identifier, and ARD Date is displayed on the print prewview.
            //Step 9  Click the Cancel button,
                      //Verify the user is returned to the Assessment Overview page.
            //Step 10 Click the Action Driodown menu. 
                      //Select Print.
            //Step 11 Click the Print button on the bottom of the Print Preview.
            //Step 12 Select appropriate printer.
                      //Select appropriate number of copies.
                      //Select the Print button on the bottom of the Windows dialog Print Preview.
                      //Verify that the assessment is printed on the selected printer.
            //Step 13 Click the Cancel button on the Assessment Print Preview
            //Step 14 Verify that the answers displayed on the printed assessment match what is answered in the MDS assessment.
        }
    }
}
