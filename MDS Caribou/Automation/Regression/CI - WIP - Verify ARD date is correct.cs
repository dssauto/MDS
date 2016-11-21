using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class CI___WIP___Verify_ARD_date_is_correct : BaseSetup
    {
        [Test]
        public void CI_WIP___Verify_ARD_date_is_correct()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            SchedulePage.MoveSlider(120);
            //Step 2  "Click  OBRA assessments and uncheck PPS form on Work In Progress page:
            //        Admission assessment
            //        Quarterly review assessment
            //        Annual assessment"
            Driver.ClickOn(WorkInProgressPage.ppsFilterButtonChecked);
            //Step 3  Verify that ARD date has displayed correctly for Admission assessment
            //Step 4  Verify that ARD date has displayed correctly for Quarterly review assessment
            //Step 5  Verify that ARD date has displayed correctly for Annual assessment
            SchedulePage.VerifyOBRAassessmentType();
            //Step 6  "Uncheck OBRA and Open PPS assessments form on Work In Progress page:
            //        5 - day scheduled assessment
            //        14 - day scheduled assessment
            //        30 - day scheduled assessment
            //        60 - day scheduled assessment
            //        90 - day scheduled assessment"
            Driver.ClickOn(WorkInProgressPage.obraFilterButtonChecked);
            Driver.ClickOn(WorkInProgressPage.ppsFilterButtonUnchecked);
            SchedulePage.VerifyPPSassessmentType();
            //Step 7  "Verify that ARD date has displayed correctly for 5 - day scheduled assessment"          
            //Step 8  Verify that ARD date has displayed correctly for 14 - day scheduled assessment
            //Step 9  Verify that ARD date has displayed correctly for 30 - day scheduled assessment
            //Step 10 Verify that ARD date has displayed correctly for 60 - day scheduled assessment
            //Step 11 Verify that ARD date has displayed correctly for 90 - day scheduled assessment
        }
    }
}
