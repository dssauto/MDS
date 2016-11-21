using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class AF___View_Security_Events: BaseSetup
    {
        [Test]
        public void AF_View_Security_Events()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToSchedulePage();
            //Step 1  Sign in as Caribou.
            //Step 2  Admin tile> Security Events from left hand menu options.
            //Step 3  "Verify Events are displayed including:
            //        Date
            //        System UserName
            //        Facility
            //        Action
            //        Description
            //        Subject System UserName
            //        Subject Facility"
            //Step 4  Select User Picture Icon> SIGN OUT.
            //Step 5  "Sign in as Caribou.
            //        Admin tile> Security Events from left hand menu options."
            //Step 6  Verfify log in by Caribou is displayed with correct date and time and is displayed as last entry in Security Event log.

        }
    }
}
