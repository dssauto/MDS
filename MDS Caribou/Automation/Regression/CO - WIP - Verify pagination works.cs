using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class CO___WIP___Verify_pagination_works : BaseSetup
    {
        [Test]
        public void CO_WIP___Verify_pagination_works()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  Verify that Work In Progress page open from First page by default
            VerifyElement.IsPresent(By.XPath("//li[@class='pagination-page ng-scope active']/a[text()='1']"));
            //Step 3  Click NEXT button
            Driver.ClickOn(WorkInProgressPage.nextButton);
            //Step 4  Click Last page
            Driver.ClickOn(By.XPath("//li[@class='pagination-page ng-scope'][last()]/a"));
            //Step 5  Click Previous button
            Driver.ClickOn(WorkInProgressPage.previousButton);
        }
    }
}
