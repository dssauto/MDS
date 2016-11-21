using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class CP___WIP___Open_WIP_button_Functionality : BaseSetup
    {
        [Test]
        public void CP_WIP___Open_WIP_button_Functionality()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  Click OPEN WIP button for any resident on the First page
            Driver.ClickOn(By.XPath("(//button[@class='btn btn-wip pull-right ng-scope'])[1]"));
            //Step 3  Click Work In Progress link
            Driver.ClickOn(By.XPath("(//a[@href='/CaribouCLCSuite/menu/workinprogress'])[2]"));
            //Step 4  Open Second page for Work In Progress
            Driver.ClickOn(WorkInProgressPage.nextButton);
            Driver.WaitFor(1);
            //Step 5  Click OPEN WIP button for any resident on the Second page
            Driver.ClickOn(By.XPath("(//button[@class='btn btn-wip pull-right ng-scope'])[1]"));
            //Step 6  Click Work In Progress link
            Driver.ClickOn(By.XPath("(//a[@href='/CaribouCLCSuite/menu/workinprogress'])[2]"));
            //Step 7  Open Last page for Work In Progress
            Driver.ClickOn(By.XPath("(//li[@class='pagination-page ng-scope']/a)[last()]"));
            //Step 8  Click OPEN WIP button for any resident on the Last page
            Driver.ClickOn(By.XPath("(//button[@class='btn btn-wip pull-right ng-scope'])[1]"));
        }
    }
}
