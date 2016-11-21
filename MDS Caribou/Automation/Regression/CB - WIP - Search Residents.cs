using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class CB___WIP__Search_Residents : BaseSetup
    {
        [Test]
        public void CB_WIP__Search_Residents()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  Verify that "Search Resident's Last Name" is default field and empty
            VerifyElement.IsPresent(By.Id("lastName"));
            //Step 3  Type in the "Search Resident's Last  Name" field only one letter from existing resident name
            IWebElement ele = Driver.Instance.FindElement(By.Id("lastName"));
            ele.SendKeys("R");
            Driver.WaitFor(1);
            ele.SendKeys("A");
            Driver.WaitFor(2);
            //Step 4  Verify that List with Last Name residents sorted alphabetically correctly and start with searched  letter
            //Step 5  Click one of the searched Last Name residents
            IWebElement eleList = Driver.Instance.FindElement(By.XPath("(//ul[@class='dropdown-menu ng-isolate-scope']/child::li)[1]"));
            eleList.Click();
            //Step 6  Delete everything in the "Search Resident's Last Name" field
            ele.Clear();
            //Step 7  Type in the "Search Resident's Last  Name" field two consecutive letters from existing residents name
            ele.SendKeys("R");
            Driver.WaitFor(1);
            ele.SendKeys("A");
            Driver.WaitFor(2);
            //Step 8  Verify that List with Last Name residents sorted alphabetically correctly and start with searched letters
            //Step 9  Click one of the searched Last Name residents
            IWebElement eleList2 = Driver.Instance.FindElement(By.XPath("(//ul[@class='dropdown-menu ng-isolate-scope']/child::li)[1]"));
            eleList2.Click();
            //Step 10 Delete everything in the "Search Resident's Last Name" field
            ele.Clear();
            //Step 11 Type in the Search Resident Last  Name field whole name (Last, First) of existing resident
            ele.SendKeys("RAIMDSRESIDENT");
            Driver.WaitFor(2);
            //Step 12 Verify that Name of resident(s) displayed correctly
            //Step 13 Delete everything in the "Search Resident Last Name" field
            ele.Clear();
            //Step 14 Select Enter on the keypad(empty enter)
            //Step 15 Type digits
            ele.SendKeys("232131243");
            ele.Clear();
            //Step 16 Type special characters
            ele.SendKeys("@!#!@#%^");
            ele.Clear();
            //Step 17 Paste latter
            ele.SendKeys("RA");
            ele.Clear();
            //Step 18 Paste digits
            //Step 19 Paste special characters
            ele.SendKeys("RA");
            ele.Clear();
        }
    }
}
