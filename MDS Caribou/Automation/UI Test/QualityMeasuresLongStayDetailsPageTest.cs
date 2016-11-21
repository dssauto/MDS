using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class QualityMeasuresLongStayDetailsPageTest : BaseSetup
    {
        [Test]
        public void TC040_QualityMeasuresLongStayDetails_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            //LandingPage.NavigateToReportsFormsPage();
            //DashboardPage.NavigateToQualityMeasures();
            //DashboardPage.NavigateToQualityMeasuresLongStayDetails();
            Driver.Instance.Navigate().GoToUrl("http://cariboudevweb.dssinc.com/CaribouCLCSuite/menu/dashboard/qualityindicatorslongterm");
            Driver.WaitFor(2);
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.XPath("//div[@id='navbar']/header/nav/div/ui-breadcrumbs/ol/li/a/i")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Caribou CLC Suite", Driver.Instance.FindElement(By.LinkText("Caribou CLC Suite")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Reports & Forms", Driver.Instance.FindElement(By.LinkText("Reports & Forms")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Quality Indicators & Measures - Long Term", Driver.Instance.FindElement(By.CssSelector("li.ng-scope.active > span.ng-binding")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.XPath("//div[@id='navbar']/header/nav/div[2]/div/div/i")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.XPath("//div[@id='navbar']/header/nav/div[2]/div/div[3]/i")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.CssSelector("img.img-circle.user-image")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Quality Measures Long Stay Details", Driver.Instance.FindElement(By.CssSelector("h1")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.XPath("//input[@type='text']")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.XPath("(//button[@type='button'])[2]")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.CssSelector("button.btn.btn-default")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.XPath("//section[@id='main-content']/div/div/div/div/div/div/div/div[3]/button")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("MDS 3.0 Facility Level Quality Measure Report - Resident Detail (Long Stay)", Driver.Instance.FindElement(By.CssSelector("h2.text-center")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Facility ID:", Driver.Instance.FindElement(By.CssSelector("td.ng-binding")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Report Period:", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr/th/table/tbody/tr/td[2]")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Facility Name:", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr/th/table/tbody/tr[2]/td")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Run Date:", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr/th/table/tbody/tr[2]/td[2]")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("City/State:", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr/th/table/tbody/tr[3]/td")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Resident Name", Driver.Instance.FindElement(By.CssSelector("th > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("A0310A/B/F", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[2]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("One or More Falls with Major Injury N013.01(L)", Driver.Instance.FindElement(By.CssSelector("th.vertical > div > span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Moderate to Severe Pain N014.02(L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[4]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("High-Risk With Pressure Ulcers N015.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[5]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Assessed/Appropriately Given FluVacc N016.02 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[6]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Received FluVacc N017.02(L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[7]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Offered and Declined FluVacc N018.02 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[8]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Did Not Receive FluVacc, Contraindicated N019.02 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[9]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Assessed/Appropriately Given PneumoVacc N020.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[10]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Received the PneumoVacc N021.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[11]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Offered and Declined PneumoVacc N022.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[12]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Didn’t Receive PneumoVac, Contraindicated N023.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[13]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Urinary Tract Infection N024.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[14]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Have/Had Cath Inserted + Left in Bladder N026.02(L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[15]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Physically Restrained N027.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[16]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Need for ADL help Increased N028.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[17]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Lose Too Much Weight N029.01(L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[18]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Received Antipsychotic Medication N031.02(L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[19]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Prevalence of Falls N032.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[20]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Prevalence of Antianxiety/Hypnotic Use N033.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[21]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Prevalence of Behavior SX Affect Others N034.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[22]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Declined in Independence in Locomotion N035.01 (L)", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[23]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Quality Measure Count", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[2]/th[24]/div/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Data", Driver.Instance.FindElement(By.XPath("//table[@id='divToPrint']/thead/tr[3]/th")).Text);
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
                Assert.AreEqual("v2.1.49", Driver.Instance.FindElement(By.XPath("//footer[@id='footer']/span[2]")).Text);
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