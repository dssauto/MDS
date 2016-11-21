using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class EO___Create_Entry_Tracking_Validate_NT_item_set_displays : BaseSetup
    {
        [Test]
        public void EO_Create_Entry_Tracking_Validate_NT_item_set_displays()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Click the Resident History Tile.
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Enter the name of the resident to create the Entry Tracking assessment on in the Resident History Sear box
            SearchResidentsPage.FindResidentWithAssessment();
            //Step 3  Select the resident tile.
            //Step 4  Click the "Create MDS" button.
            Driver.ClickOn(ResidentsHistoryPage.createNewMDSBtn);
            SchedulePage.VistALogin();
            //Step 5  Select the correct coding for an NT item set.
            CreateNewMDSPage.AddEntryDate();
            //The NC item set coding is as follows:
            //99
            Driver.ClickOn(SchedulePage.a99RadioBtn);
            //99.
            Driver.ClickOn(SchedulePage.b99RadioBtn);
            //0.
            Driver.ClickOn(SchedulePage.c0RadioBtn);
            //01.
            Driver.ClickOn(SchedulePage.f01RadioBtn);
            //Step 6  Click the "Create" button.
            Driver.ClickOn(SchedulePage.createNewMDSCreateBtnEnabled);
            //Step 7  By comparing with the currently coded specs, verify that the assessment that is displayed, matches that of the CMS NT items set spec from the manual. 
            //Validate Section A - Z.
            VerifyElement.IsPresent(AssessmentPage.sectionALink);
            VerifyElement.IsPresent(AssessmentPage.sectionZLink);
        }
    }
}
