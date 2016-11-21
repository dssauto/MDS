using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class CE___WIP__Verify_Resident_Information_Displays : BaseSetup
    {
        [Test]
        public void CE_WIP__Verify_Resident_Information_Displays()
        {
            Browser.Open();
            LoginPage.SignIn();
            //CPRS Required
            //Step 1  Select Work In Progress tile.
            //Step 2  Click Residents Name on the Residents Tiles on the First page
            //Step 3  Open CPRS and find same patient
            //Step 4  Verify that data displayed correctly on the Resident's Demographics page
            //Step 5  Click Close button
            //Step 6  Click Residents Name on the Residents Tiles on LAST page
            //Step 7  Open CPRS and find same patient
            //Step 8  Verify that data displayed correctly on the Resident's Demographics page
            //Step 9  Click Close button
            //Step 10 Click Residents Name on the Residents Tiles on the Second page
            //Step 11 Find patient in the CPRS
            //Step 12 Verify that data displayed correctly on the Resident's Demographics page
            //Step 13 Click Close button
        }
    }
}
