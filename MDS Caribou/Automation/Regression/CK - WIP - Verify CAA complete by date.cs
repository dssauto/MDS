using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;


namespace Automation.Regression
{
    [TestFixture]
    class CK___WIP___Verify_CAA_complete_by_date : BaseSetup
    {
        [Test]
        public void CK_WIP___Verify_CAA_complete_by_date()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  "Uncheck PPS assessments form on Work In Progress page
            Driver.ClickOn(WorkInProgressPage.ppsFilterButtonChecked);
            //        Admission assessment
            //        Annual assessment"
            //Step 3  Verify that CAA Complete by Date Column has displayed correctly on Work In Progress page for Admission assessment
            //Step 4  Verify that Complete by Date Column has displayed correctly on Work In Progress  for Annual assessment
        }
    }
}
