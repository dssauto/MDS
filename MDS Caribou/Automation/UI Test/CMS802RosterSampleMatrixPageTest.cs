using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class CMS802RosterSampleMatrixPageTest : BaseSetup
    {
        [Test]
        public void TC026_CMS802_RosterSampleMatrixPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
            Driver.WaitFor(2);
            DashboardPage.NavigateToCMS802();
            Driver.WaitFor(2);
            VerifyElement.IsPresent(CMS802Page.homeIcon);
            VerifyElement.IsPresent(CMS802Page.caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(CMS802Page.reportsFormsNavbar);
            VerifyElement.IsPresent(CMS802Page.cms802Navbar);
            VerifyElement.IsPresent(CMS802Page.notificationBellIcon);
            VerifyElement.IsPresent(CMS802Page.syncStatusIcon);
            VerifyElement.IsPresent(CMS802Page.profileIcon);
            VerifyElement.AreEqual(CMS802Page.pageHeader, "CMS-802 Roster/Sample Matrix");
            VerifyElement.IsPresent(CMS802Page.printButton);
            VerifyElement.IsPresent(CMS802Page.instructionsButton);
            VerifyElement.IsPresent(CMS802Page.addRowButton);
            VerifyElement.IsPresent(CMS802Page.saveButton);
            VerifyElement.IsPresent(CMS802Page.selectExistingButton);
            VerifyElement.IsPresent(CMS802Page.createNewButton);
            Driver.ClickOn(CMS802Page.createNewButton);
            Driver.WaitFor(2);
            VerifyElement.AreEqual(CMS802Page.neighborhoodsHeader, "Neighborhoods");
            VerifyElement.AreEqual(CMS802Page.selectNeighborhoodLabel, "Select Neighborhood");
            VerifyElement.IsPresent(CMS802Page.selectNeighborhoodDropdown);
            VerifyElement.IsPresent(CMS802Page.cancelButton);
            VerifyElement.IsPresent(CMS802Page.confrimButton);
            Driver.ClickOn(CMS802Page.cancelButton);
            VerifyElement.AreEqual(CMS802Page.informationMessage, "All information entered by computer should be verified by a staff member knowledgeable about the resident population.");
            try
            {
                Assert.AreEqual("Resident Number", Driver.Instance.FindElement(By.CssSelector("#header1 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Resident Room", Driver.Instance.FindElement(By.CssSelector("#header2 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Surveyor Assigned", Driver.Instance.FindElement(By.CssSelector("#header3 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Total Sample", Driver.Instance.FindElement(By.XPath("//div[@id='divToPrint']/div/div/table/thead/tr/th[4]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Phase 1", Driver.Instance.FindElement(By.XPath("//div[@id='divToPrint']/div/div/table/thead/tr/th[4]/div[2]/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Phase 2", Driver.Instance.FindElement(By.XPath("//div[@id='divToPrint']/div/div/table/thead/tr/th[4]/div[3]/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Individual Interview (I)", Driver.Instance.FindElement(By.XPath("//div[@id='divToPrint']/div/div/table/thead/tr/th[4]/div[4]/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Family Interview (F)", Driver.Instance.FindElement(By.XPath("//div[@id='divToPrint']/div/div/table/thead/tr/th[4]/div[5]/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Closed Record (CL)", Driver.Instance.FindElement(By.XPath("//div[@id='divToPrint']/div/div/table/thead/tr/th[4]/div[6]/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Comprehensive (C)", Driver.Instance.FindElement(By.XPath("//div[@id='divToPrint']/div/div/table/thead/tr/th[4]/div[7]/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Focused Review (FO)", Driver.Instance.FindElement(By.XPath("//div[@id='divToPrint']/div/div/table/thead/tr/th[4]/div[8]/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("ARD", Driver.Instance.FindElement(By.CssSelector("#header5 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Interview: Individual/Family", Driver.Instance.FindElement(By.CssSelector("#header6 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Closed Record/Comprehensive/Focused", Driver.Instance.FindElement(By.CssSelector("#header7 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Privacy/Dignity Issues", Driver.Instance.FindElement(By.CssSelector("#header8 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Social Services", Driver.Instance.FindElement(By.CssSelector("#header9 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Self-Determination/Accommodation of Needs", Driver.Instance.FindElement(By.CssSelector("#header10 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Abuse/Neglect", Driver.Instance.FindElement(By.CssSelector("#header11 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Clean/Comfort/Homelike", Driver.Instance.FindElement(By.CssSelector("#header12 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Moderate/Severe Pain (Constant or Frequent)", Driver.Instance.FindElement(By.CssSelector("label > strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Hi-Risk Pressure Ulcer (Stage 2-4)", Driver.Instance.FindElement(By.CssSelector("#header14 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("New/Worsened Pressure Ulcers (Stage 2-4)", Driver.Instance.FindElement(By.CssSelector("#header15 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Physical Restraints", Driver.Instance.FindElement(By.CssSelector("#header16 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Falls including Falls with Major Injury", Driver.Instance.FindElement(By.CssSelector("#header17 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Psychoactive Meds with Absence of Condition", Driver.Instance.FindElement(By.CssSelector("#header18 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Antianxiety/Hypnotic Medication Use", Driver.Instance.FindElement(By.CssSelector("#header19 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Behavior Symptoms Affecting Others/Self", Driver.Instance.FindElement(By.CssSelector("#header20 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Depressive Symptoms", Driver.Instance.FindElement(By.CssSelector("#header21 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Urinary Tract Infection", Driver.Instance.FindElement(By.CssSelector("#header22 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Indwelling Urinary Catheter", Driver.Instance.FindElement(By.CssSelector("#header23 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Lo-Risk Resident Lose Bowel/Bladder Control", Driver.Instance.FindElement(By.CssSelector("#header24 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Excessive Weight Loss/Gain", Driver.Instance.FindElement(By.CssSelector("#header25 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Need for Increased ADL Help", Driver.Instance.FindElement(By.CssSelector("#header26 > div > label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Hospice", Driver.Instance.FindElement(By.CssSelector("#header27 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Dialysis", Driver.Instance.FindElement(By.CssSelector("#header28 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Admittance/Transfer/Discharge", Driver.Instance.FindElement(By.CssSelector("#header29 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("MI (Non-Dementia) or ID/DD", Driver.Instance.FindElement(By.CssSelector("#header30 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Language/Communication", Driver.Instance.FindElement(By.CssSelector("#header31 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Vision/Hearing/Other Assistive Devices", Driver.Instance.FindElement(By.CssSelector("#header32 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("ROM/Contractures/Positioning", Driver.Instance.FindElement(By.CssSelector("#header33 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Specialty Care (Tubefeeding, Central Lines, Ventilators, O2)", Driver.Instance.FindElement(By.CssSelector("#header34 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Hydration/Swallowing/Oral Health", Driver.Instance.FindElement(By.CssSelector("#header35 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Infections", Driver.Instance.FindElement(By.CssSelector("#header36 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Specialized Rehab Services (OT, PT, Speech, etc)", Driver.Instance.FindElement(By.CssSelector("#header37 > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Resident Name", Driver.Instance.FindElement(By.Id("header4")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("(No Current Report)", Driver.Instance.FindElement(By.XPath("//div[@id='divToPrint']/div/div/table/tbody/tr/td")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }

            try
            {
                Assert.AreEqual("Caribou CLC Suite", Driver.Instance.FindElement(By.CssSelector("span.pull-left.ng-binding")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                VerifyElement.IsPresent(By.XPath("//footer[@id='footer']/span[2]"));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Selenium, Facility", Driver.Instance.FindElement(By.XPath("//footer[@id='footer']/span[3]")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Developed by DSS, Inc. © 2016", Driver.Instance.FindElement(By.CssSelector("span.pull-right")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
        }
    }
}