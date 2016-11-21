using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class CG___WIP___Verify_Admit_Discharge_Date_is_correct : BaseSetup
    {
        [Test]
        public void CG_WIP___Verify_Admit_Discharge_Date_is_correct()
        {
            Browser.Open();
            LoginPage.SignIn();
            //CPRS Required
            //Step 1  Select Work In Progress tile.
            //Step 2  Open CPRS and find one of the patient from First Work In Progress page
            //Step 3  Verify that Admit / Discharge date has displayed correctly on Work In Progress page
            //Step 4  Open Last Work In Progress page
            //Step 5  Open CPRS and find one of the patient from Last Work In Progress page
            //Step 6  Verify that Admit / Discharge date has displayed correctly on Work In Progress page
            //Step 7  Open Second Work In Progress page
            //Step 8  Open CPRS and find one of the patient from Last Work In Progress page
            //Step 9  Verify that Admit / Discharge date has displayed correctly on Work In Progress page
        }
    }
}
