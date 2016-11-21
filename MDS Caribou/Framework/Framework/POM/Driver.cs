using Framework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Framework.POM
{
    public class Driver : BaseDriver
    {
        private static SelectElement select;
        private static IWebElement element;
        public static IWebElement GetVisibleElement(By locator)
        {
            try
            {
                (new WebDriverWait(Instance, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
                return Instance.FindElement(locator);
            }
            catch (Exception)
            {
                throw new NoSuchElementException("Element is not found: " + locator.ToString());
            }
        }
        public static IWebElement GetClickableElement(By locator)
        {
            try
            {
                (new WebDriverWait(Instance, TimeSpan.FromSeconds(20))).Until(ExpectedConditions.ElementToBeClickable(locator));
                return Instance.FindElement(locator);
            }
            catch (Exception)
            {
                throw new NoSuchElementException("<br>Element is not found: " + locator.ToString());
            }
        }
        // Wait 
        public static void WaitFor(int iSecond)
        {
            Thread.Sleep(iSecond * 1000);
            //Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(iSecond));
        }
        public static void WaitForElement(By locator)
        {
            //WebDriverWait wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(10));
            //IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(locator));
            (new WebDriverWait(Instance, TimeSpan.FromSeconds(10))).Until(ExpectedConditions.ElementIsVisible(locator));
        }
        public static void WaitForPageLoad()
        {
            Instance.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
        }
        public static void WaitForScriptTimeout()
        {
            Instance.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));
        }
        // Click 
        public static void ClickOn(By locator)
        {
            element = GetClickableElement(locator);
            element.Click();
            TestReport.Log(LogStatus.Pass, "Successfully clicked on: " + locator.ToString());
        }
        public static void ClickRadioButton(By locator)
        {
            element = GetClickableElement(locator);
            element.Click();
            TestReport.Log(LogStatus.Pass, "Successfully checked on: " + locator);
        }
        // Enter
        public static void PressEnter(By locator)
        {
            WaitForElement(locator);
            element = GetClickableElement(locator);
            element.SendKeys(Keys.Enter);
            TestReport.Log(LogStatus.Pass, "Successfully pressed on: " + locator);
        }
        // Input
        public static void InsertText(By locator, string text)
        {
            element = GetVisibleElement(locator);
            element.Clear();
            element.SendKeys(text);
            TestReport.Log(LogStatus.Pass, "Successfully '" + text + "' text inserted into: " + locator.ToString());
        }
        // Dropdown
        public static void SelectElement(By locator, string text)
        {
            select = new SelectElement(GetVisibleElement(locator));
            select.SelectByText(text);
        }
        public static void SelectDropdown(By locator, string value)
        {
            //element = GetClickableElement(locator);
            //element.Click();
            select = new SelectElement(GetVisibleElement(locator));
            select.SelectByText(value);
            //SelectElement(locator, value);
            //Instance.FindElement(By.XPath(value)).Click();
            TestReport.Log(LogStatus.Pass, "Successfully '" + value + "' dropdown option selected from: " + locator.ToString());
        }
        public static void SelectFromDropdown(By locator, By value)
        {
            element = GetClickableElement(locator);
            element.Click();
            element = GetClickableElement(value);
            element.Click();
            TestReport.Log(LogStatus.Pass, "Successfully '" + value + "' dropdown option selected from: " + locator.ToString());
        }
        public static void VerifyDropdownList(By locator, string value)
        {
            element = GetVisibleElement(locator);
            element.Click();
            VerifyElement.AreEqual(locator, value);
        }
        public static IList<string> GetAllItem(By locator)
        {
            select = new SelectElement(GetClickableElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }
        public static int GetRaws(By locator)
        {
            Driver.WaitForElement(locator);
            int count = Driver.Instance.FindElements(locator).Count;
            return count;
        }
        public static bool IsElementPresent(By by)
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
    }
}
