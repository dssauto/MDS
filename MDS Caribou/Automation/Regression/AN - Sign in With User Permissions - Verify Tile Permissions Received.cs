using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class AN___Sign_in_With_User_Permissions___Verify_Tile_Permissions_Received: BaseSetup
    {
        [Test]
        public void AN_Sign_in_With_User_Permissions_Verify_Tile_Permissions_Received()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToSchedulePage();
            //Step 1  Log in as new user creating role created in previous step.	Menu tile page displayed.
            //Step 2  Verify tiles assigned to role are displayed.Tiles assigned to role are displayed.
            //Step 3  Click on each tile displayed to verify user as access to tiles displayed.User has access to tiles.
        }
    }
}
