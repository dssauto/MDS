using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EJ___Switch_Bed
    {
        [Test]
        public void EJ_Switch_Bed()
        {
            Browser.Open();
            LoginPage.SignIn();
            //VistA Required
            //Step 1  Click the Resident History tile.
            //Step 2  "Enter the name of a resident to complete a Switch Bed on into the search residents text box. 
                      //Once the resident tile is displayed, select the resident tile."
            //Step 3  Click the Residents name in the upper left corner of the Residents History page.
            //Step 4  Take a screenshot of the resident demographics page, noting the Room -Bed the resident is in.
            //Step 5  "Open a VistA terminal window via the blue cube in the system tray.
                      //Select appropriate server.
                      //Follow the attached document to complete a Switch Bed."
            //Step 6  While still on the demographics page in the Caribou MDS website, click the sync button on the bottom of the resident demographics dialog.
            //Step 7  Verify against the screenshot taken previously that the new Room - Bed entered in VistA is displayed on the resident demographics page.
        }
    }
}
