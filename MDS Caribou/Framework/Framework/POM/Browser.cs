using Framework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.ObjectModel;
using System.Configuration;

namespace Framework.POM
{
    public class Browser : BaseSetup
    {
        public static void Open()
        {
            String url = ConfigurationManager.AppSettings["URL"];
            Driver.Instance.Navigate().GoToUrl(url);
            TestReport.Log(LogStatus.Pass, "Successfully navigated to: " + url);
        }
        public static void Close()
        {
            Driver.Instance.Quit();
            TestReport.Log(LogStatus.Pass, "Browser closed");
        }
        public static void Maximize()
        {
            Driver.Instance.Manage().Window.Maximize();
            TestReport.Log(LogStatus.Pass, "Browser maximized");
        }
        public static void GoBack()
        {
            Driver.Instance.Navigate().Back();
            TestReport.Log(LogStatus.Pass, "Navigated back");
        }
        public static void RefreshPage()
        {
            Driver.Instance.Navigate().Refresh();
            TestReport.Log(LogStatus.Pass, "Page refreshed");
        }
        public static void SwitchToWindow(int index = 0)
        {
            Driver.WaitFor(1);
            ReadOnlyCollection<string> windows = Driver.Instance.WindowHandles;
            if ((windows.Count - 1) < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }
            Driver.Instance.SwitchTo().Window(windows[index]);
            Driver.WaitFor(1);
            Browser.Maximize();
            TestReport.Log(LogStatus.Pass, "Switched to new window");
        }
        public static void SwitchToParent()
        {
            var windowids = Driver.Instance.WindowHandles;
            for (int i = windowids.Count - 1; i > 0;)
            {
                Driver.Instance.Close();
                i = i - 1;
                Driver.WaitFor(1);
                Driver.Instance.SwitchTo().Window(windowids[i]);
            }
            Driver.Instance.SwitchTo().Window(windowids[0]);
            TestReport.Log(LogStatus.Pass, "Switched back to main window");
        }
        public static void SwitchToIFrame(By locator)
        {
            Driver.Instance.SwitchTo().Frame(Driver.Instance.FindElement(locator));
        }
        public static void CloseNewTab()
        {
            Actions action = new Actions(Driver.Instance);
            action.KeyDown(Keys.Control).SendKeys("w").KeyUp(Keys.Control).Perform();
            SwitchToParent();
        }

        public static void ScrollToElement(string v)
        {
            IWebElement element = Driver.Instance.FindElement(By.XPath(v));
            IJavaScriptExecutor js = Driver.Instance as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
