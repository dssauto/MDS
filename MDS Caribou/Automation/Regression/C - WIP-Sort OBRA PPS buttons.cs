using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class C___WIP_Sort_OBRA_PPS_buttons : BaseSetup
    {
        [Test]
        public void C_WIP_Sort_OBRA_PPS_buttons()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  Verify that OBRA and PPS buttons checked
            VerifyElement.IsPresent(WorkInProgressPage.obraFilterButtonChecked);
            VerifyElement.IsPresent(WorkInProgressPage.ppsFilterButtonChecked);
            //Step 3  Verify that Work In Progress page is include OBRA and PPS assessments
            SchedulePage.MoveSlider(120);
            Driver.WaitFor(2);
            WorkInProgressPage.VerifyOBRAAssessments();
            WorkInProgressPage.VerifyPPSAssessments();
            //Step 4  Click OBRA button
            Driver.ClickOn(WorkInProgressPage.obraFilterButtonChecked);
            //Step 5  Verify that Work In Progress page is include only PPS assessments
            WorkInProgressPage.VerifyPPSAssessments();
            //Step 6  Click PPS button
            Driver.ClickOn(WorkInProgressPage.ppsFilterButtonChecked);
            //Step 7  Verify that Schedule page is include OBRA and PPS assessments
            //Step 8  Click OBRA button
            Driver.ClickOn(WorkInProgressPage.obraFilterButtonUnchecked);
            //Step 9  Verify that Work In Progress page page is include only OBRA assessments
            WorkInProgressPage.VerifyOBRAAssessments();
        }

    }
}
