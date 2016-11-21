using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class AE___Import_RUG_Rates: BaseSetup
    {
        [Test]
        public void AE_Import_RUG_Rates()
        {
            Browser.Open();
            LandingPage.NavigateToSchedulePage();
            //Step 1  "Precondition:
            //        RUG csv file"
            //Step 2  Sign in as Caribou.
            LoginPage.SignIn();
            //Step 3  Admin Tile> RUG Rates from left side menu.
            SidebarMenu.NavigateToRugRates();
            //Step 4  Click Browse.
            //Step 5  "Locate csv file to be uploaded.
            //        Click on file and select Open."
            //Step 6  Click IMPORT.
            //Step 7  Repeat Steps 4 - 6 for all years csv files to be IMPORTED.
            //Step 8  Select Caribou CLC Suite from breadcrumb in right upper corner.
        }
    }
}
