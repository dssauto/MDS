using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class FacilityDisciplinePageTest : BaseSetup
    {
        [Test]
        public void TC028_FacilityDiscipline_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToAdminPage();
            AdminPage.NavigateToUsersRoles();
            Driver.WaitFor(2);
            Driver.ClickOn(UsersRolesPage.addDisciplineButton);
            Driver.WaitFor(2);
            try
            {
                Assert.AreEqual("Facility Discipline", Driver.Instance.FindElement(By.CssSelector("h3.modal-title")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Discipline Name", Driver.Instance.FindElement(By.CssSelector("label.control-label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.Id("DisciplineName")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Description", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[2]/label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.Id("Description")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.XPath("//body[@id='mds']/div/div/div/div[3]/div/div[2]/button")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.CssSelector("button.btn.btn-primary")));
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
                Assert.AreEqual("Developed by DSS, Inc. © 2016", Driver.Instance.FindElement(By.XPath("//*[@id='footer']/span[4]")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
        }
    }
}