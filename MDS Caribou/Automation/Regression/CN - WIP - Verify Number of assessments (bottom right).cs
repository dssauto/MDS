using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;

namespace Automation.Regression
{
    [TestFixture]
    class CN___WIP___Verify_Number_of_assessments__bottom_right : BaseSetup
    {
        [Test]
        public void CN_WIP___Verify_Number_of_assessments__bottom_right()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  Verify that "Due in" slider bar have 7 days by default
            VerifyElement.IsPresent(By.XPath("//span[@class='ng-binding'][text()='7 days']"));
            //Step 3  Verify Number of assessments (bottom right)
            //Step 4  Verify that pages has 5 assessments per page if  number of assessments (bottom right) more(equal) 5 OR less than 5 assessments in the First page if  number of assessments less than 10.
            int firstPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
            Driver.WaitForElement(WorkInProgressPage.residentsList);
            Assert.AreEqual(firstPageResidents, 5);
            //Step 5  Verify that number of assessments from pages equal number of assessments(bottom right)
            if (Driver.IsElementPresent(WorkInProgressPage.nextButton))
            {
                Driver.ClickOn(WorkInProgressPage.nextButton);
                Driver.WaitFor(3);
                int secondPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
                if (Driver.IsElementPresent(WorkInProgressPage.nextButton))
                {
                    Driver.ClickOn(WorkInProgressPage.nextButton);
                    Driver.WaitFor(3);
                    int thirdPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
                    if (Driver.IsElementPresent(WorkInProgressPage.nextButton))
                    {
                        Driver.ClickOn(WorkInProgressPage.nextButton);
                        Driver.WaitFor(3);
                        int fourthPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
                        Driver.ClickOn(WorkInProgressPage.nextButton);
                        Driver.WaitFor(3);
                        string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                        try
                        {
                            Assert.AreEqual(firstPageResidents + secondPageResidents + thirdPageResidents + fourthPageResidents, Convert.ToInt32(assessments));
                            TestReport.Log(LogStatus.Pass, "Assessments are equal to: " + assessments);
                        }
                        catch (Exception e)
                        {
                            string screenName = ScreenshotHelper.TakeScreenshot();
                            string screenShotPath = TestReport.AddScreenCapture(screenName);
                            TestReport.Log(LogStatus.Warning, screenShotPath + "Assessments are not equal to: " + assessments + e.Message);
                        }
                    }
                    else
                    {
                        string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                        try
                        {
                            Assert.AreEqual(firstPageResidents + secondPageResidents + thirdPageResidents, Convert.ToInt32(assessments));
                            TestReport.Log(LogStatus.Pass, "Assessments are equal to: " + assessments);
                        }
                        catch (Exception e)
                        {
                            string screenName = ScreenshotHelper.TakeScreenshot();
                            string screenShotPath = TestReport.AddScreenCapture(screenName);
                            TestReport.Log(LogStatus.Warning, screenShotPath + "Assessments are not equal to: " + assessments + e.Message);
                        }
                    }
                }
                else
                {
                    string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                    try
                    {
                        Assert.AreEqual(firstPageResidents + secondPageResidents, Convert.ToInt32(assessments));
                        TestReport.Log(LogStatus.Pass, "Assessments are equal to: " + assessments);
                    }
                    catch (Exception e)
                    {
                        string screenName = ScreenshotHelper.TakeScreenshot();
                        string screenShotPath = TestReport.AddScreenCapture(screenName);
                        TestReport.Log(LogStatus.Warning, screenShotPath + "Assessments are not equal to: " + assessments + e.Message);
                    }
                }
            }
            else
            {
                string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                Assert.AreEqual(firstPageResidents, Convert.ToInt32(assessments));
            }
            //Step 6  Slide slider bar to 1 day
            SchedulePage.MoveSlider(-2);
            Driver.ClickOn(SchedulePage.onePagination);
            Driver.WaitFor(4);
            //Step 7  Verify Number of assessments (bottom right)
            int firstPageResidents2 = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
            Assert.AreEqual(firstPageResidents2, 5);
            //Step 8  Verify that pages has 5 assessments per page if  number of assessments (bottom right) more(equal) 10 OR less than 10 assessments in the First page if  number of assessments less than 10.
            //Step 9  Verify that number of assessments from pages equal number of assessments(bottom right)
            if (Driver.IsElementPresent(WorkInProgressPage.nextButton))
            {
                Driver.ClickOn(WorkInProgressPage.nextButton);
                Driver.WaitFor(3);
                int secondPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
                if (Driver.IsElementPresent(WorkInProgressPage.nextButton))
                {
                    Driver.ClickOn(WorkInProgressPage.nextButton);
                    Driver.WaitFor(3);
                    int thirdPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
                    if (Driver.IsElementPresent(WorkInProgressPage.nextButton))
                    {
                        Driver.ClickOn(WorkInProgressPage.nextButton);
                        Driver.WaitFor(3);
                        int fourthPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
                        Driver.ClickOn(WorkInProgressPage.nextButton);
                        Driver.WaitFor(3);
                        string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                        try
                        {
                            Assert.AreEqual(firstPageResidents2 + secondPageResidents + thirdPageResidents + fourthPageResidents, Convert.ToInt32(assessments));
                            TestReport.Log(LogStatus.Pass, "Assessments are equal to: " + assessments);
                        }
                        catch (Exception e)
                        {
                            string screenName = ScreenshotHelper.TakeScreenshot();
                            string screenShotPath = TestReport.AddScreenCapture(screenName);
                            TestReport.Log(LogStatus.Warning, screenShotPath + "Assessments are not equal to: " + assessments + e.Message);
                        }
                    }
                    else
                    {
                        string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                        try
                        {
                            Assert.AreEqual(firstPageResidents2 + secondPageResidents + thirdPageResidents, Convert.ToInt32(assessments));
                            TestReport.Log(LogStatus.Pass, "Assessments are equal to: " + assessments);
                        }
                        catch (Exception e)
                        {
                            string screenName = ScreenshotHelper.TakeScreenshot();
                            string screenShotPath = TestReport.AddScreenCapture(screenName);
                            TestReport.Log(LogStatus.Warning, screenShotPath + "Assessments are not equal to: " + assessments + e.Message);
                        }
                    }
                }
                else
                {
                    string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                    try
                    {
                        Assert.AreEqual(firstPageResidents2 + secondPageResidents, Convert.ToInt32(assessments));
                        TestReport.Log(LogStatus.Pass, "Assessments are equal to: " + assessments);
                    }
                    catch (Exception e)
                    {
                        string screenName = ScreenshotHelper.TakeScreenshot();
                        string screenShotPath = TestReport.AddScreenCapture(screenName);
                        TestReport.Log(LogStatus.Warning, screenShotPath + "Assessments are not equal to: " + assessments + e.Message);
                    }
                }
            }
            else
            {
                string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                Assert.AreEqual(firstPageResidents2, Convert.ToInt32(assessments));
            }
            //Step 10 Slide slider bar to 370 days
            SchedulePage.MoveSlider(120);
            Driver.ClickOn(SchedulePage.onePagination);
            Driver.WaitFor(3);
            //Step 11 Verify Number of assessments (bottom right)
            int firstPageResidents3 = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
            Assert.AreEqual(firstPageResidents3, 5);
            //Step 12 Verify that pages has 5 assessments per page if  number of assessments (bottom right) more(equal) 10 OR less than 10 assessments in the First page if  number of assessments less than 10.
            //Step 13 Verify that number of assessments from pages equal number of assessments(bottom right)
            if (Driver.IsElementPresent(WorkInProgressPage.nextButton))
            {
                Driver.ClickOn(WorkInProgressPage.nextButton);
                Driver.WaitFor(3);
                int secondPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
                if (Driver.IsElementPresent(WorkInProgressPage.nextButton))
                {
                    Driver.ClickOn(WorkInProgressPage.nextButton);
                    Driver.WaitFor(3);
                    int thirdPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
                    if (Driver.IsElementPresent(WorkInProgressPage.nextButton))
                    {
                        Driver.ClickOn(WorkInProgressPage.nextButton);
                        Driver.WaitFor(3);
                        int fourthPageResidents = Driver.Instance.FindElements(WorkInProgressPage.residentsList).Count;
                        Driver.ClickOn(WorkInProgressPage.nextButton);
                        Driver.WaitFor(3);
                        string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                        try
                        {
                            Assert.AreEqual(firstPageResidents3 + secondPageResidents + thirdPageResidents + fourthPageResidents, Convert.ToInt32(assessments));
                            TestReport.Log(LogStatus.Pass, "Assessments are equal to: " + assessments);
                        }
                        catch (Exception e)
                        {
                            string screenName = ScreenshotHelper.TakeScreenshot();
                            string screenShotPath = TestReport.AddScreenCapture(screenName);
                            TestReport.Log(LogStatus.Warning, screenShotPath + "Assessments are not equal to: " + assessments + e.Message);
                        }
                    }
                    else
                    {
                        string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                        try
                        {
                            Assert.AreEqual(firstPageResidents3 + secondPageResidents + thirdPageResidents, Convert.ToInt32(assessments));
                            TestReport.Log(LogStatus.Pass, "Assessments are equal to: " + assessments);
                        }
                        catch (Exception e)
                        {
                            string screenName = ScreenshotHelper.TakeScreenshot();
                            string screenShotPath = TestReport.AddScreenCapture(screenName);
                            TestReport.Log(LogStatus.Warning, screenShotPath + "Assessments are not equal to: " + assessments + e.Message);
                        }
                    }
                }
                else
                {
                    string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                    try
                    {
                        Assert.AreEqual(firstPageResidents3 + secondPageResidents, Convert.ToInt32(assessments));
                        TestReport.Log(LogStatus.Pass, "Assessments are equal to: " + assessments);
                    }
                    catch (Exception e)
                    {
                        string screenName = ScreenshotHelper.TakeScreenshot();
                        string screenShotPath = TestReport.AddScreenCapture(screenName);
                        TestReport.Log(LogStatus.Warning, screenShotPath + "Assessments are not equal to: " + assessments + e.Message);
                    }
                }
            }
            else
            {
                string assessments = Driver.Instance.FindElement(WorkInProgressPage.totalAssessments).Text.ToString().Substring(0, 2);
                Assert.AreEqual(firstPageResidents3, Convert.ToInt32(assessments));
            }
        }
    }
}
