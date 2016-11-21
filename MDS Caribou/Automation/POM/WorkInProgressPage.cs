using Framework.Base;
using Framework.POM;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;

namespace Automation.POM
{
    class WorkInProgressPage : BaseSetup
    {
        #region WebElements

        static internal By obraFilterButtonChecked = By.XPath("//i[@class='glyphicon glyphicon-ok colorblue ng-scope' and @ng-if='filterButton.obra == true']");
        static internal By obraFilterButtonUnchecked = By.XPath("//*[@id='assessmentTypeButtonGroup']/label[1]");
        static internal By ppsFilterButtonChecked = By.XPath("//i[@class='glyphicon glyphicon-ok colorblue ng-scope' and @ng-if='filterButton.pps == true']");
        static internal By ppsFilterButtonUnchecked = By.XPath("(//div[@id='assessmentTypeButtonGroup']/label)[2]");
        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By workInProgressNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By workInProgressIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span/i");
        static internal By workInProgressTitle = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");
        static internal By sliderBar = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div[1]/div/div[2]/ul/li[2]/div/a");
        static internal By lastNameSearchTextField = By.Id("lastName");
        static internal By selectLocationDropdown = By.Id("selectLocation");
        static internal By residentColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[1]/span");
        static internal By admitDischargeColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[1]");
        static internal By assessmentTypeColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[2]");
        static internal By ardColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[3]");
        static internal By rnVerifyColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[4]");
        static internal By completeByDateColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[5]");
        static internal By caaCompleteByColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[6]");
        static internal By carePlanReviewColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[7]");
        static internal By refreshButton = By.XPath("//button[@class='btn btn-default pull-right']");
        static internal By previousButton = By.XPath("//a[@class='ng-binding'][contains(., 'Previous')]");
        static internal By nextButton = By.XPath("//li[@class='pagination-next ng-scope']/a");
        static internal By residentsList = By.XPath("//li[@class='list-group-item ng-scope']");
        static internal By totalAssessments = By.XPath("//span[@class='pull-right ng-binding']");
        //Residents Tiles
        //OPEN WIP button for each residents
        //Number of page on the list
        //Number of Assessments in the lower right corner
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");
        // Assessments
        static internal By admissionAssessment = By.XPath("(//span[@class='label ng-binding ng-scope'][contains(., 'Admission')])[1]");
        static internal By quarterlyAssessment = By.XPath("(//span[@class='label ng-binding ng-scope'][contains(., 'Quarterly')])[1]");
        static internal By thirtydayAssessment = By.XPath("(//span[@class='label ng-binding ng-scope'][contains(., '30-day')])[1]");
        static internal By sixtydayAssessment = By.XPath("(//span[@class='label ng-binding ng-scope'][contains(., '60-day')])[1]");
        static internal By ninetydayAssessment = By.XPath("(//span[@class='label ng-binding ng-scope'][contains(., '90-day')])[1]");
        static internal By fivedayAssessment = By.XPath("(//span[@class='label ng-binding ng-scope'][contains(., '5-day')])[1]");
        static internal By fourteendayAssessment = By.XPath("(//span[@class='label ng-binding ng-scope'][contains(., '14-day')])[1]");

        #endregion

        #region Action
        internal static void VerifyOBRAAssessments()
        {
            if (Driver.IsElementPresent(admissionAssessment) || Driver.IsElementPresent(quarterlyAssessment))
            {
                TestReport.Log(LogStatus.Pass, "OBRA Assessments are present!");
            }
            else
            {
                Driver.ClickOn(SchedulePage.nextPagination);
                Driver.WaitFor(3);
                if (Driver.IsElementPresent(admissionAssessment) || Driver.IsElementPresent(quarterlyAssessment))
                {
                    TestReport.Log(LogStatus.Pass, "OBRA Assessments are present!");
                }
                else
                {
                    TestReport.Log(LogStatus.Warning, "OBRA Assessments are not present!");
                }
            }
        }
        internal static void VerifyPPSAssessments()
        {
            if (Driver.IsElementPresent(thirtydayAssessment) || Driver.IsElementPresent(sixtydayAssessment) || Driver.IsElementPresent(ninetydayAssessment) || Driver.IsElementPresent(fivedayAssessment) || Driver.IsElementPresent(fourteendayAssessment))
            {
                TestReport.Log(LogStatus.Pass, "OBRA Assessments are present!");
            }
            else
            {
                TestReport.Log(LogStatus.Warning, "OBRA Assessments are not present!");
            }
        }
        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.IsPresent(workInProgressIcon);
            VerifyElement.AreEqual(workInProgressTitle, "Work In Progress");
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Work In Progress");
            VerifyElement.AreEqual(obraFilterButtonChecked, "OBRA");
            VerifyElement.AreEqual(ppsFilterButtonChecked, "PPS");
            VerifyElement.IsPresent(sliderBar);
            VerifyElement.AreEqual(residentColumnLabel, "Resident");
            VerifyElement.AreEqual(admitDischargeColumnLabel, "Admit Discharge");
            VerifyElement.AreEqual(assessmentTypeColumnLabel, "AssessmentsPage Type");
            VerifyElement.AreEqual(ardColumnLabel, "ARD");
            VerifyElement.AreEqual(rnVerifyColumnLabel, "RN Verify");
            VerifyElement.AreEqual(completeByDateColumnLabel, "Complete By Date");
            VerifyElement.AreEqual(caaCompleteByColumnLabel, "CAA Complete By");
            VerifyElement.AreEqual(carePlanReviewColumnLabel, "Care Plan Review");
            VerifyElement.IsPresent(refreshButton);

            //Residents Tiles
            //OPEN WIP button for each residents
            //Number of page on the list
            //Number of Assessments in the lower right corner

            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.AreEqual(versionFooter, "v2.1.1.49");
            VerifyElement.AreEqual(userFooter, "Selenium, Facility");
            VerifyElement.IsPresent(developedByFooter);

        }
        #endregion
        #region Actions
        internal static void VerifyOBRAassessmentType()
        {
            try
            {
                // Admission
                if (Driver.IsElementPresent(admissionAssessment))
                {
                    VerifyElement.IsPresent(admissionAssessment);
                }
                else
                {
                    Driver.ClickOn(SchedulePage.nextPagination);
                    VerifyElement.IsPresent(admissionAssessment);
                    Driver.ClickOn(SchedulePage.previousPagination);
                }
                // Quarterly
                if (Driver.IsElementPresent(quarterlyAssessment))
                {
                    VerifyElement.IsPresent(quarterlyAssessment);
                }
                else
                {
                    Driver.ClickOn(SchedulePage.nextPagination);
                    VerifyElement.IsPresent(quarterlyAssessment);
                    Driver.ClickOn(SchedulePage.previousPagination);
                }
                VerifyElement.IsNotPresent(SchedulePage.fivedayAssessment);
                VerifyElement.IsNotPresent(SchedulePage.fourteendayAssessment);
                VerifyElement.IsNotPresent(SchedulePage.thirtydayAssessment);
                VerifyElement.IsNotPresent(SchedulePage.sixtydayAssessment);
                VerifyElement.IsNotPresent(SchedulePage.ninetydayAssessment);
            }
            catch (Exception e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
        }
        #endregion

        #region Navigation

        public static void NavigateTo()
        {
        }
        #endregion

    }
}