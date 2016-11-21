using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class EK___Sync : BaseSetup
    {
        [Test]
        public void EK_Sync()
        {
            Browser.Open();
            LoginPage.SignIn();
            //VistA   Required
            //Step 1  Click the Resident History tile.
            //Step 2  "Enter the name of a resident that is NOT admitted into the facility into the search residents text  box on the search residents page. 
            //Verify that the resident name entered is NOT displayed on the Search Residents page."
            //Step 3  Sign out of the Caribou MDS website.
            //Step 4  "Open VistA cube in system tray. 
            //Select Server. 
            //Follow the attached document to admit a resident into the desired facility."
            //Step 5  "Reopen the Caribou MDS website and login with the same user as was signed in previously. 
            //Once Signed in, Select the Resident History tile."
            //Step 6  "In the upper right corner of the Caribou MDS website there are 3 icons displayed. 
            //From left to right:
            //Notification Bell.
            //Sync Button.
            //User Icon. 
            //Click the Sync button."
            //Step 7  Verify that the VistA Synchronization dropdown is displayed.
            //Step 8  Verify that there are changes made from the user in previous steps displayed in the VistA Synchronization dropdown.
            //Step 9  Click the "Connect" button in the VistA Synchronization dropdown.
            //Step 10 "Enter the Access / Verify code for the user that is signed in. 
            //Click the Sign In button."
            //Step 11 "Enter the residents name that was admitted in previous steps into the Search Residents text box. 
            //Verify now that the user has synced the resident name that was admitted previously is displayed in a tile on the Search Residents page."
            //Step 12 Click the residents tile.
            //Step 13 CLick the residents name in the top left corner of the residents history page.
            //Step 14 Verify the information for the resident that was admitted is displayed properly on the resident demographics page(Room, bed, neighborhood) and that the status for the resident is Active - On Ward.
            //Step 15 Click the Sync button.
            //Step 16 Verify that the Blue "Connect" button that was displayed before the user synched is now a green "Sync" button because the user has already synched.
            //Step 17 Click the Sync button.
        }
    }
}
