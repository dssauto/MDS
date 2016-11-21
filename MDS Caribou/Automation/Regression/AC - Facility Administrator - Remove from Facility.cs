using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class AC___Facility_Administrator___Remove_from_Facility: BaseSetup
    {
        [Test]
        public void AC_Facility_Administrator_Remove_from_Facility()
        {
            Browser.Open();           
            //Step 1  Sign in as Caribou.
            LoginPage.SignIn();
            //Step 2  Admin Tile> Facilities from left hand menu.

            //Step 3  Select Facility Administrator to be removed from > ADMIN button.
            //Step 4  Click REMOVE ADMINISTRATOR
            //Step 5  Click Yes.
        }
    }
}
