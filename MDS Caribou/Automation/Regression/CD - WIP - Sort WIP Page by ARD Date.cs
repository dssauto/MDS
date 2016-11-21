using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;

namespace Automation.Regression
{
    [TestFixture]
    class CD___WIP___Sort_WIP_Page_by_ARD_Date : BaseSetup
    {
        [Test]
        public void CD_WIP___Sort_WIP_Page_by_ARD_Date()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  Verify that FIRST PAGE of Assessments sorted in increasing order by ARD date on Work In Progress page
            SchedulePage.MoveSlider(120);
            Driver.WaitFor(2);
            string ardDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='day ng-binding'])[1]")).Text.ToString();
            string ardMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='month ng-binding'])[1]")).Text.ToString();
            string ardYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='year ng-binding'])[1]")).Text.ToString();
            // Convert ARD days to date and time
            DateTime FirstArdDate = new DateTime(Convert.ToInt32(ardYear), SchedulePage.ConvertMonthString(ardMonth), Convert.ToInt32(ardDay));
            string lastardDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='day ng-binding'])[last()]")).Text.ToString();
            string lastardMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='month ng-binding'])[last()]")).Text.ToString();
            string lastardYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='year ng-binding'])[last()]")).Text.ToString();
            // Convert ARD days to date and time
            DateTime LastArdDate = new DateTime(Convert.ToInt32(lastardYear), SchedulePage.ConvertMonthString(lastardMonth), Convert.ToInt32(lastardDay));
            if (FirstArdDate <= LastArdDate)
            {
                TestReport.Log(LogStatus.Pass, "Assessments sorted in increasing order by ARD date");
            }
            else
            {
                TestReport.Log(LogStatus.Warning, "Assessments not sorted in increasing order by ARD date");
            }
            //Step 3  Click SECOND Work In Progress page
            Driver.ClickOn(SchedulePage.nextPagination);
            //Step 4  Verify that SECOND PAGE of Assessments sorted in increasing order by ARD date on Work In Progress page
            Driver.WaitFor(3);
            string ardDay2 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='day ng-binding'])[1]")).Text.ToString();
            string ardMonth2 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='month ng-binding'])[1]")).Text.ToString();
            string ardYear2 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='year ng-binding'])[1]")).Text.ToString();
            // Convert ARD days to date and time
            DateTime FirstArdDate2 = new DateTime(Convert.ToInt32(ardYear2), SchedulePage.ConvertMonthString(ardMonth2), Convert.ToInt32(ardDay2));
            string lastardDay2 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='day ng-binding'])[last()]")).Text.ToString();
            string lastardMonth2 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='month ng-binding'])[last()]")).Text.ToString();
            string lastardYear2 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='year ng-binding'])[last()]")).Text.ToString();
            // Convert ARD days to date and time
            DateTime LastArdDate2 = new DateTime(Convert.ToInt32(lastardYear2), SchedulePage.ConvertMonthString(lastardMonth2), Convert.ToInt32(lastardDay2));
            if (FirstArdDate2 <= LastArdDate2)
            {
                TestReport.Log(LogStatus.Pass, "Assessments sorted in increasing order by ARD date");
            }
            else
            {
                TestReport.Log(LogStatus.Warning, "Assessments not sorted in increasing order by ARD date");
            }
            //Step 5  Click LAST Work In Progress page
            Driver.ClickOn(SchedulePage.lastPagination);
            //Step 6  Verify that LAST PAGE of Assessments sorted in increasing order by ARD date on Work In Progress
            Driver.WaitFor(2);
            string ardDay3 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='day ng-binding'])[1]")).Text.ToString();
            string ardMonth3 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='month ng-binding'])[1]")).Text.ToString();
            string ardYear3 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='year ng-binding'])[1]")).Text.ToString();
            // Convert ARD days to date and time
            DateTime FirstArdDate3 = new DateTime(Convert.ToInt32(ardYear3), SchedulePage.ConvertMonthString(ardMonth3), Convert.ToInt32(ardDay3));
            string lastardDay3 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='day ng-binding'])[last()]")).Text.ToString();
            string lastardMonth3 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='month ng-binding'])[last()]")).Text.ToString();
            string lastardYear3 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope']//span[@class='year ng-binding'])[last()]")).Text.ToString();
            // Convert ARD days to date and time
            DateTime LastArdDate3 = new DateTime(Convert.ToInt32(lastardYear3), SchedulePage.ConvertMonthString(lastardMonth3), Convert.ToInt32(lastardDay3));
            if (FirstArdDate3 <= LastArdDate3)
            {
                TestReport.Log(LogStatus.Pass, "Assessments sorted in increasing order by ARD date");
            }
            else
            {
                TestReport.Log(LogStatus.Warning, "Assessments not sorted in increasing order by ARD date");
            }
        }
    }
}
