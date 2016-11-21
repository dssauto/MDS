using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class ResidentsHistoryPage
    {
        #region WebElements
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");
        static internal By hideArchivedBtn = By.XPath("//label[@class='btn btn-default active toggle-off']");
        static internal By showArchivedBtn = By.XPath("//label[@class='btn btn-primary toggle-on']");
        static internal By createNewMDSBtn = By.XPath("//button[@ng-click='openCreateNewAssessmentModal()']");
        static internal By actionBtn = By.XPath("//button[@aria-disabled='true']");
        static internal By refreshIcon = By.XPath("//a[@class='btn btn-default pull-right']");
        static internal By assessmentTypeTitle = By.XPath("//label[@class='header_label'][text()='Assessment Type']");
        static internal By a0050Title = By.XPath("//label[@class='header_label'][text()='A0050']");
        static internal By aRDTitle = By.XPath("//label[@class='header_label'][text()='ARD']");
        static internal By completeDateTitle = By.XPath("//label[@class='header_label'][text()='Complete Date']");
        static internal By rugScoreTitle = By.XPath("//label[@class='header_label'][text()='Rug Score']");
        static internal By statusTitle = By.XPath("//label[@class='header_label'][text()='Status']");
        static internal By submissionStatusTitle = By.XPath("//label[@class='header_label'][text()='Submission Status']");
        static internal By batchDateTitle = By.XPath("//label[@class='header_label'][text()='Batch #, Date']");
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.AreEqual(pageHeader, "Resident's History");
            VerifyElement.IsPresent(hideArchivedBtn);
            VerifyElement.IsPresent(createNewMDSBtn);
            VerifyElement.IsPresent(actionBtn);
            VerifyElement.IsPresent(refreshIcon);
            VerifyElement.IsPresent(assessmentTypeTitle);
            VerifyElement.IsPresent(a0050Title);
            VerifyElement.IsPresent(aRDTitle);
            VerifyElement.IsPresent(completeDateTitle);
            VerifyElement.IsPresent(rugScoreTitle);
            VerifyElement.IsPresent(statusTitle);
            VerifyElement.IsPresent(submissionStatusTitle);
            VerifyElement.IsPresent(batchDateTitle);
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.AreEqual(developedByFooter, "Developed by DSS, Inc. © 2016");
        }

        #endregion

        #region Navigation

        public static void NavigateTo()
        {
        }
        #endregion

    }
}