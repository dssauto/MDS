using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class DG___Resident_History___Residents__History_Grid___Assessment_type_A0050_ARD_Complete_Date_Rug_Score_Status_Submission_Status_Batch_Number_Date_Refresh_button_are_displayed : BaseSetup
    {
        [Test]
        public void DG_Resident_History_Residents_History_Grid_Assessment_type_A0050_ARD_Complete_Date_Rug_Score_Status_Submission_Status_Batch_Number_Date_Refresh_button_are_displayed()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click SEARCH button
            //Step 3  Select resident tile from the FIRST page
            SearchResidentsPage.FindResidentWithAssessment();
            //Step 4  Verify that Residents History Grid displayed Assessment type
            //Step 5  Verify that Residents History Grid displayed A0050
            //Step 6  Verify that Residents History Grid displayed ARD
            //Step 7  Verify that Residents History Grid displayed Complete Date
            //Step 8  Verify that Residents History Grid displayed Rug Score
            //Step 9  Verify that Residents History Grid displayed Status
            //Step 10 Verify that Residents History Grid displayed Submission Status
            //Step 11 Verify that Residents History Grid displayed Batch #, Date
            //Step 12 Verify that Residents History Grid displayed Refresh button
            ResidentsHistoryPage.VerifyPageElements();
        }
    }
}
