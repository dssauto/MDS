using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class AA___Create_New_Facility : BaseSetup
    {
        [Test]
        public void AA_Create_New_Facility()
        {
            Browser.Open();
            //Step 1  "On Caribou CLC Suite URL page:
            //        Enter Email Address of Caribou user.
            //        Enter Password of Caribou User.
            //        Enter All Facilities from Select Facility drop down.
            //        Click SIGN IN button."
            LoginPage.SignIn();
            //Step 2  Select Admin Tile.
            LandingPage.NavigateToAdminPage();
            //Step 3  Select Facilities from left hand menu.
            //Step 4  Select + ADD button.
            //Step 5  "Enter Information Listed for New Facility to be added.
            //        Facility Name
            //        Station Number
            //        VSOA Server URL
            //        VSOA Server ID
            //        CAA Note Service Category
            //        CAA Note Title IEN
            //        Assessment Note Service Category
            //        Assessment Note Title IEN
            //        Address
            //        City
            //        State
            //        Zip Code
            //        Geo Code(autopopulates based on address, city, state, zip code)
            //        Press GEOCODE button only if Geo Code does not populate and needs to be refreshed.
            //        Press Cancel"
            //Step 6  Verify New Facility is NOT added to Facility list.
            //Step 7  Select Facilities from left hand menu.
            //Step 8  Select + ADD button.
            //Step 9  "Enter Information Listed for New Facility to be added.
            //        Facility Name
            //        Station Number
            //        VSOA Server URL
            //        VSOA Server ID
            //        CAA Note Service Category
            //        CAA Note Title IEN
            //        Assessment Note Service Category
            //        Assessment Note Title IEN
            //        Address
            //        City
            //        State
            //        Zip Code
            //        Geo Code(autopopulates based on address, city, state, zip code)
            //        Press GEOCODE button only if Geo Code does not populate and needs to be refreshed.
            //        Press Save"
            //Step 10 Verify New Facility is added to Facility list.

        }
    }
}
