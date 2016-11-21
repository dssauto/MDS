using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class CW___Resident_History_Tile___HIDE_SHOW_Archive_button_functionality : BaseSetup
    {
        [Test]
        public void CW_Resident_History_Tile___HIDE_SHOW_Archive_button_functionality()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click SEARCH button
            Driver.ClickOn(SearchResidentsPage.searchButton);
            //Step 3  Select resident tile from page
            SearchResidentsPage.NavigateToResidentsHistoryPage();
            //Step 4  Verify that "HIDE ARCHIVED / SHOW ARCHIVED" slider button has 'HIDE REMOVED" as default slider button
            VerifyElement.IsPresent(ResidentsHistoryPage.hideArchivedBtn);
            //Step 5  Verify that ARCHIVED assessments don't display on the page
            //Step 6  Click "HIDE ARCHIVED" on the slider button
            Driver.ClickOn(ResidentsHistoryPage.hideArchivedBtn);
            //Step 7  Verify that ARCHIVED assessments display on the page
            VerifyElement.IsPresent(ResidentsHistoryPage.showArchivedBtn);
        }
    }
}
