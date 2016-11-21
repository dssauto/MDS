using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EQ___Create_Quarterly_Validate_NQ_item_set_displays
    {
        [Test]
        public void EQ_Assessment_Create_Quarterly_Validate_NQ_item_set_displays()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Click the Schedule Tile.
            //Step 2  Enter the name of the resident to create the Quarterly assessment on in the Search text box.
            //Step 3  Select the resident name from the dropdown menu.
            //Step 4  On the line item for the Quarterly assessment click the "Create MDS" button.
            //Step 5  Select the correct coding for an NC item set.
                      //The NC item set coding is as follows:
                      //2.
                      //99.
                      //0.
                      //99.
            //Step 6  Click the "Create" button.
            //Step 7  By comparing with the currently coded specs, verify that the assessment that is displayed, matches that of the CMS NQ items set spec from the manual. 
                      //Validate Section A - Z."
        }
    }
}
