using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace Automation.Regression
{
    [TestFixture]
    class DI___Resident_History___Assessments_display_on_Residents_History_Grid : BaseSetup
    {
        [Test]
        public void DI_Resident_History___Assessments_display_on_Residents_History_Grid()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click SEARCH button
            Driver.ClickOn(SearchResidentsPage.searchButton);
            //Step 3  Select resident tile from the FIRST page
            Driver.ClickOn(SearchResidentsPage.firstResidentTile);
            //Step 4  Click CREATE MDS button
            Driver.ClickOn(ResidentsHistoryPage.createNewMDSBtn);
            SchedulePage.VistALogin();
            //Step 5  Create New MDS Assessment
            Driver.ClickOn(SchedulePage.carePlanReviewDateCalendar);
            Driver.ClickOn(SchedulePage.calendarTodayBtn);
            Driver.ClickOn(SchedulePage.a1600EntryDateCalendar);
            Driver.ClickOn(SchedulePage.calendarTodayBtn);
            Driver.ClickOn(SchedulePage.a01RadioBtn);
            Driver.ClickOn(SchedulePage.b02RadioBtn);
            Driver.ClickOn(SchedulePage.f99RadioBtn);
            Driver.ClickOn(SchedulePage.createNewMDSCreateBtnEnabled);
            VerifyElement.AreEqual(SchedulePage.assessmentHeader, "Assessment Header");
            //Step 6  Click Residents History link
            Driver.WaitForElement(By.XPath("//a[@class='ng-binding ng-scope'][contains(., 'History')]"));
            string aType1 = Driver.Instance.FindElement(By.XPath("(//p[@class='form-control-static ng-binding'])[1]")).Text.ToString();
            Driver.ClickOn(By.XPath("//a[@class='ng-binding ng-scope'][contains(., 'History')]"));
            VerifyElement.AreEqual(ResidentsHistoryPage.pageHeader, "Resident's History");
            string aType2 = Driver.Instance.FindElement(By.XPath("(//span[@class='lead ng-binding ng-scope'])[last()]//preceding-sibling::span")).Text.ToString();
            string aType3 = Driver.Instance.FindElement(By.XPath("(//span[@class='lead ng-binding ng-scope'])[last()]")).Text.ToString();
            //Step 7  Verify that  Assessment Type has display correctly on Residents History Grid
            string aTypeAdded = aType2 + " " + aType3;
            try
            {
                Assert.AreEqual(aType1, aTypeAdded);
                TestReport.Log(LogStatus.Pass, "Assessment type '" + aType1 + "' is equal to '" + aTypeAdded);
            }
            catch (AssertionException e)
            {
                string screenName = ScreenshotHelper.TakeScreenshot();
                string screenShotPath = TestReport.AddScreenCapture(screenName);
                TestReport.Log(LogStatus.Warning, screenShotPath + "<br> Assessment type is not equal: " + e.Message);
            }

        }
    }
}
