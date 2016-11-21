using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class CA___WIP_Due_in_xx_days_slider_bar : BaseSetup
    {
        [Test]
        public void CA_WIP_Due_in_xx_days_slider_bar()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  Verify that slider bar has 7 days by default
            VerifyElement.IsPresent(By.XPath("//span[@class='ng-binding'][text()='7 days']"));
            //Step 3  Slide slider bar to 1 day
            SchedulePage.MoveSlider(-2);
            //Step 4  Verify by ARD date that Work In Progress page does not show any assessments later than due in 1 day
            //Step 5  Slide slider bar to 0 day
            //Step 6  Slide slider bar to 370 days
            //Step 7  Verify by ARD date that Work In Progress page does not show any assessments later than due in 370 days
            //Step 8  Slide slider bar to 371 days
            //Step 9  Slide slider bar to 10 days
            //Step 10 Verify by ARD date that Work In Progress page does not show any assessments later than due in 10 days
        }
    }
}
