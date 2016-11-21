using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class FacilityRolePageTest : BaseSetup
    {
        [Test]
        public void TC029_FacilityRole_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToAdminPage();
            AdminPage.NavigateToUsersRoles();
            Driver.WaitFor(2);
            Driver.ClickOn(UsersRolesPage.addRoleButton);
            Driver.WaitFor(1);
            try
            {
                Assert.AreEqual("Facility Role", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div/h3")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Role Name", Driver.Instance.FindElement(By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[1]/label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.Id("roleName")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Checked means Read/Write, unchecked means Read-Only", Driver.Instance.FindElement(By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[2]/small")).Text);
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
                Assert.IsTrue(Driver.IsElementPresent(By.Id("description")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Permissions", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Read Users, Roles, Disciplines", Driver.Instance.FindElement(By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[1]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Write Users, Roles, Disciplines", Driver.Instance.FindElement(By.XPath("//li[2]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Read Assessments", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[3]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Write Assessments", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[4]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Manage Assessments", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[5]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Read Residents", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[6]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Write Residents (Sync)", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[7]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Write Schedule", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[9]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Read Batches", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[10]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Write Batches", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[11]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Read Reports", Driver.Instance.FindElement(By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[12]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Write Reports", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[13]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Read Settings", Driver.Instance.FindElement(By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[14]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Write Settings", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[3]/ul/li[15]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Account Settings", Driver.Instance.FindElement(By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/form/div[3]/ul/li[16]/div/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Sections Permissions", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div[4]/label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("CANCEL", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[3]/div/div[2]/button")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("SAVE", Driver.Instance.FindElement(By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/div[1]/div[2]/button[2]")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
        }
    }
}