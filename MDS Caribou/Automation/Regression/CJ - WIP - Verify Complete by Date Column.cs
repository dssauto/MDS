using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class CJ___WIP___Verify_Complete_by_Date_Column : BaseSetup
    {
        [Test]
        public void CJ_WIP___Verify_Complete_by_Date_Column()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            SchedulePage.MoveSlider(120);
            //Step 2  "Uncheck PPS assessments form on Work In Progress page:
            //        Admission assessment
            //        Quarterly review assessment
            //        Annual assessment"
            Driver.ClickOn(WorkInProgressPage.ppsFilterButtonChecked);
            Driver.WaitFor(2);
            //Step 3  Verify that Complete by Date Column has displayed correctly on Work In Progress page for Admission assessment
            //Step 4  Verify that Complete by Date Column has displayed correctly on Work In Progress for Quarterly review assessment
            //Step 5  Verify that Complete by Date Column has displayed correctly on Work In Progress for Annual assessment
            WorkInProgressPage.VerifyOBRAassessmentType();
        }
    }
}
