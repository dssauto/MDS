using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class EP_Assessment___Create_Admission_Validate_NC_item_set_displays : BaseSetup
    {
        [Test]
        public void EP_Assessment_Create_Admission_Validate_NC_item_set_displays()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Click the Schedule Tile.
            LandingPage.NavigateToSchedulePage();
            //Step 2  Enter the name of the resident to create an admission assessment on in the Search text box.
            Driver.ClickOn(SchedulePage.refreshFilterButton);
            //Step 3  Select the resident name from the dropdown menu.
            //Step 4  On the line item for the Admission assessment click the "Create Assessment" button.
            Driver.ClickOn(SchedulePage.createMDSBtn);
            //Step 5  Select the correct coding for an NC item set.
            SchedulePage.VistALogin();
            //The NC item set coding is as follows:
            CreateNewMDSPage.AddEntryDate();
            //1.
            Driver.ClickOn(SchedulePage.a01RadioBtn);
            //99.
            Driver.ClickOn(SchedulePage.b99RadioBtn);
            //0.
            Driver.ClickOn(SchedulePage.c0RadioBtn);
            //99.
            Driver.ClickOn(SchedulePage.f01RadioBtn);
            //Step 6  Click the "Create" button.
            Driver.ClickOn(SchedulePage.createNewMDSCreateBtnEnabled);
            //Step 7  By comparing with the currently coded specs, verify that the assessment that is displayed, matches that of the CMS NC items set spec from the manual. 
            //Validate Section A - Z.
        }
    }
}
