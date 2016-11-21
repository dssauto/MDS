using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class CF___WIP___Verify_Resident_Admission_Date_displays_correctly : BaseSetup
    {
        [Test]
        public void CF_WIP___Verify_Resident_Admission_Date_displays_correctly()
        {
            Browser.Open();
            LoginPage.SignIn();
            //CPRS Required
            //Step 1  Select Work In Progress tile.
            //Step 2  Click Residents Name on the Residents Tiles on the First page
            //Step 3  Open CPRS and find same patient
            //Step 4  Verify that Resident Admission Date displays correctly on the Resident's Demographics page, Work In Progress , CPRS
            //Step 5  Click Close button
            //Step 6  Click Residents Name on the Residents Tiles on the LAST page
            //Step 7  Find patient in the CPRS
            //Step 8  Verify that Resident Admission Date displays correctly on the Resident's Demographics page, Work In Progress , CPRS
            //Step 9  Click Close button
            //Step 10 Click Residents Name on the Residents Tiles on the SECOND page
            //Step 11 Find patient in the CPRS
            //Step 12 Verify that Resident Admission Date displays correctly on the Resident's Demographics page, Work In Progress , CPRS
            //Step 13 Click Close button
        }
    }
}
