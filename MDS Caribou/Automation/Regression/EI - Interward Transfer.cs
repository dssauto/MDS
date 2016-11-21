using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EI___Interward_Transfer
    {
        [Test]
        public void EI_Interward_Transfer()
        {
            Browser.Open();
            LoginPage.SignIn();
            //VistA Required
            //Step 1  Click the Resident History tile.
            //Step 2  Enter the name of a resident to complete an interward transfer on into the search residents text box. 
                      //Once the resident tile is displayed, select the resident tile.
            //Step 3  Click the Residents name in the upper left corner of the Residents History page.
            //Step 4  Take a screenshot of the resident demographics page, noting the Neighborhood and Room -Bed the resident is in.
            //Step 5  Open a VistA terminal window via the blue cube in the system tray.
                      //Select appropriate server.
                      //Follow the attached document to complete an Interward Transfer.
            //Step 6  While still on the demographics page in the Caribou MDS website, click the sync button on the bottom of the resident demographics dialog.
            //Step 7  Verify against the screenshot taken previously that the Neighborghood Location, Room -Bed, Transfer Status has changed and is correct as to what was put in VistA.
        }
    }
}
