using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class Resident_History_Tile___Pagination_functionality__Previous___Next___pages_1_2_3_etc
    {
        [Test]
        public void Resident_History_Tile__Pagination_functionality__Previous___Next___pages_1_2_3_etc()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile.
            //Step 2  Click drop down selection for  "Select Neighborhood"  field
            //Step 3  Click All Neighborhoods
            //Step 4  Click NEXT button
            //Step 5  Click Last page
            //Step 6  Click Previous button
        }
    }
}
