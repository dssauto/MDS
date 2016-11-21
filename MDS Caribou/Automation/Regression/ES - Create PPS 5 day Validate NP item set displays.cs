using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class ES___Create_PPS_5_day_Validate_NP_item_set_displays
    {

        [Test]
        public void ES_Create_PPS_5_day_Validate_NP_item_set_displays()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Click the Schedule Tile.
            //Step 2  Enter the name of a short stay resident to create a PPS 5 day assessment on in the schedule search box.
            //Step 3  Select the residents name.
            //Step 4  Click the "Create MDS" button on the line item for the PPS 5 day.
            //Step 5  Select the correct coding for an NP item set.
                      //The NC item set coding is as follows:
                      //99
                      //01.
                      //0.
                      //99.
            //Step 6  Click the "Create" button.
            //Step 7  By comparing with the currently coded specs, verify that the assessment that is displayed, matches that of the CMS NT items set spec from the manual. 
                      //Validate Section A - Z."
        }
    }
}
