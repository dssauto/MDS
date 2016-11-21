using Framework.Base;
using Framework.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;

namespace Framework.POM
{
    public class VerifyElement : BaseSetup
    {
        private static IWebElement element;
        public static void AreEqual(By locator, string elementName)
        {
            try
            {
                element = Driver.GetVisibleElement(locator);
                Assert.AreEqual(elementName, Driver.Instance.FindElement(locator).Text.Trim());
                TestReport.Log(LogStatus.Pass, "Element '" + elementName + "' is equal to '" + element.Text + "'");
            }
            catch (AssertionException e)
            {
                string screenName = ScreenshotHelper.TakeScreenshot();
                string screenShotPath = TestReport.AddScreenCapture(screenName);
                TestReport.Log(LogStatus.Warning, screenShotPath + "<br> Element is not equal: " + e.Message);
            }
        }
        public static void IsPresent(By locator)
        {
            //Driver.Instance.FindElement(locator);
            try
            {
                element = Driver.GetVisibleElement(locator);
                Assert.IsTrue(ElementPresentBool(locator));
                TestReport.Log(LogStatus.Pass, "Element is present: " + locator.ToString());
            }
            catch (AssertionException e)
            {
                string screenName = ScreenshotHelper.TakeScreenshot();
                string screenShotPath = TestReport.AddScreenCapture(screenName);
                TestReport.Log(LogStatus.Warning, screenShotPath + "<br> Element is not present: " + e.Message);
            }
        }
        public static void IsNotPresent(By locator)
        {
            try
            {
                Assert.IsFalse(ElementPresentBool(locator));
                TestReport.Log(LogStatus.Pass, "Element is not present: " + locator);
            }
            catch (AssertionException e)
            {
                string screenName = ScreenshotHelper.TakeScreenshot();
                string screenShotPath = TestReport.AddScreenCapture(screenName);
                TestReport.Log(LogStatus.Warning, screenShotPath + "<br> Element is not present: " + e.Message);
            }
        }
        public static void TitleIsPresent(string title)
        {
            try
            {
                (new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10))).Until(ExpectedConditions.TitleContains(title));
                Assert.AreEqual(title, Driver.Instance.Title);
                TestReport.Log(LogStatus.Pass, "Title is present: " + title);
            }
            catch (AssertionException e)
            {
                string screenName = ScreenshotHelper.TakeScreenshot();
                string scrrenShotPath = TestReport.AddScreenCapture(screenName);
                TestReport.Log(LogStatus.Warning, scrrenShotPath + "Title verification failed: " + e.Message);
            }
        }
        public static void ButtonIsDisabled(By locator)
        {
            try
            {
                Assert.IsNotNull(Driver.GetClickableElement((locator)).GetAttribute("disabled"));

            }
            catch (AssertionException e)
            {
                string screenName = ScreenshotHelper.TakeScreenshot();
                string scrrenShotPath = TestReport.AddScreenCapture(screenName);
                TestReport.Log(LogStatus.Warning, scrrenShotPath + "Button is not disabled: " + e.Message);
            }
        }
        public static bool ElementPresentBool(By by)
        {
            try
            {
                Driver.Instance.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public static void ExceptionLog(string message)
        {
            string screenName = ScreenshotHelper.TakeScreenshot();
            string screenShotPath = TestReport.AddScreenCapture(screenName);
            TestReport.Log(LogStatus.Warning, screenShotPath + message);
        }
    }
}
