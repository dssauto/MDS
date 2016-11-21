using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class SelectReportFromListPageTest : BaseSetup
    {
        [Test]
        public void TC045_SelectReportFromList_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
            Driver.WaitFor(1);
            DashboardPage.NavigateToCMS802();
            Driver.ClickOn(CMS802Page.selectExistingButton);
            Driver.WaitFor(1);
            VerifyElement.AreEqual(SelectReportFromListPage.pageHeader, "Select report from list");
            VerifyElement.IsPresent(SelectReportFromListPage.badgeIcon);
            VerifyElement.AreEqual(SelectReportFromListPage.reportDateLabel, "Report Date");
            VerifyElement.AreEqual(SelectReportFromListPage.userNameLabel, "User Name");
            VerifyElement.AreEqual(SelectReportFromListPage.titleLabel, "Title");
            VerifyElement.IsPresent(SelectReportFromListPage.iCheckHelperLabel);
            VerifyElement.IsPresent(SelectReportFromListPage.cancelButton);
            VerifyElement.IsPresent(SelectReportFromListPage.confirmButton);
            Driver.ClickOn(SelectReportFromListPage.cancelButton);

        }
    }
}