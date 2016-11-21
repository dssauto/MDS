using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class AD___Import_Historical_Data: BaseSetup
    {
        [Test]
        public void AD_Import_Historical_Data()
        {
            Browser.Open();
            //Step 1  Sign in as Caribou.
            LoginPage.SignIn();
            //Step 2  Admin Tile> Facilities from left hand menu.
            //Step 3  Select Facility from list that 12 months of data to be imported for> Click IMPORT.
            //Step 4  "Depending on format of received data select appropriate Browse button.
            //        (Browse for Zip selected) "
            //Step 5  Locate File and click Open.
            //Step 6  Click UPLOAD (ZIP or XML).
            //Step 7  Click Close.
            //Step 8  Login as Facility Administrator for facility > Resident History Tile.
            //Step 9  Search Residents(locate resident imported) and select name tile.
            //Step 10 Verify imported assessments display Status of Sealed / Imported with a Submisstion Status of Transmitted.
            //Step 11 Select the radio button for one of the imported assessments in Sealed / Imported status > Action > View.
            //Step 12 "Select Action.
            //        Verify there are no Unseal or Unsign buttons."
            //Step 13 "Select Section Z of the assessment from the left side menu.
            //        Scroll to Z0500.
            //        Verify there are no Unsign or Unseal buttons."
            //Step 14 Select Caribou CLC Suite from upper left hand breadcrumb and return to Menu page.

        }
    }
}
