using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class DashboardPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By reportsFormsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/header/h1");

        internal static void NavigateToRUGIV()
        {
            Driver.Instance.Navigate().GoToUrl("http://cariboudevweb.dssinc.com/CaribouCLCSuite/menu/dashboard/rugiv");
        }

        static internal By blueTile = By.XPath("//*[@id='main-content']/div/div/div[1]/div[1]/div");
        static internal By greenTile = By.XPath("//*[@id='main-content']/div/div/div[1]/div[2]/div");
        static internal By redTile = By.XPath("//*[@id='main-content']/div/div/div[1]/div[3]/div");
        static internal By purpleTile = By.XPath("//*[@id='main-content']/div/div/div[1]/div[4]/div");

        //Assessments by month
        static internal By assessmentsByMonthLabel = By.XPath("//*[@id='main-content']/div/div/div[2]/div[1]/div/div[1]");

        //Progress this month
        static internal By progressthisMonthLabel = By.XPath("//*[@id='main-content']/div/div/div[2]/div[2]/div/div[1]");

        //ADT Summary
        static internal By adtSummeryLabel = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[1]");
        static internal By adtReportButton = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[1]/button");
        static internal By notConnectedToVistAMessage = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/h4");
        static internal By connectToVistaButton = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/button");

        //Date Label 1
        static internal By dateLabel1 = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[1]/label");
        static internal By circleAdmittedIcon = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[1]/div/div[1]");
        static internal By circleDischargedIcon = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[1]/div/div[2]");
        static internal By circleTransferedIcon = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[1]/div/div[3]");

        //Date Label 2
        static internal By dateLabel2 = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[2]/label");
        static internal By admittedIcon = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[2]/div/div[1]");
        static internal By dischargedIcon = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[2]/div/div[2]");
        static internal By transferedIcon = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[2]/div/div[3]");

        //Date Label 3
        static internal By dateLabel3 = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[3]/label");
        static internal By admIcon = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[3]/div/div[1]");
        static internal By disIcon = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[3]/div/div[2]");
        static internal By transIcon = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/div/div[3]/div/div[3]");

        //Bottom
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.IsPresent(caribouCLSSuiteNavbar);
            VerifyElement.AreEqual(reportsFormsNavbar, "Reports & Forms");
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Dashboard");
            VerifyElement.IsPresent(blueTile);
            VerifyElement.IsPresent(greenTile);
            VerifyElement.IsPresent(redTile);
            VerifyElement.IsPresent(purpleTile);
            VerifyElement.AreEqual(assessmentsByMonthLabel, "Assessments by month");
            VerifyElement.AreEqual(progressthisMonthLabel, "Progress this month");
            VerifyElement.AreEqual(adtSummeryLabel, "ADT Summary");
            VerifyElement.IsPresent(adtReportButton);
            VerifyElement.IsPresent(connectToVistaButton);
            Driver.ClickOn(By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div[2]/div/button"));
            SchedulePage.VistALogin();
            VerifyElement.IsPresent(dateLabel1);
            VerifyElement.IsPresent(circleAdmittedIcon);
            VerifyElement.IsPresent(circleDischargedIcon);
            VerifyElement.IsPresent(circleTransferedIcon);
            VerifyElement.IsPresent(dateLabel2);
            VerifyElement.IsPresent(admittedIcon);
            VerifyElement.IsPresent(dischargedIcon);
            VerifyElement.IsPresent(transferedIcon);
            VerifyElement.IsPresent(dateLabel3);
            VerifyElement.IsPresent(admittedIcon);
            VerifyElement.IsPresent(disIcon);
            VerifyElement.IsPresent(transIcon);

            //Bottom
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.IsPresent(developedByFooter);

        }

        #endregion

        #region Navigation
        public static void NavigateToCMS802()
        {
            Driver.ClickOn(SidebarMenu.cms802Button);
            VerifyElement.AreEqual(CMS802Page.pageHeader, "CMS-802 Roster/Sample Matrix");
        }

        public static void NavigateToMDSAdHocReports()
        {
            Driver.ClickOn(SidebarMenu.mdsAdhocButton);
            VerifyElement.AreEqual(MDSAdhocPage.pageHeader, "MDS Ad-hoc Reports");
        }

        public static void NavigateToMDSMasterResidentList()
        {
            Driver.ClickOn(SidebarMenu.masterResidentListButton);
            VerifyElement.AreEqual(MDSMasterResidentListPage.pageHeader, "Master Resident List");
        }
        public static void NavigateToManualsAndForms()
        {
            Driver.ClickOn(SidebarMenu.manualsFromsButton);
            VerifyElement.AreEqual(ManualsAndFormsPage.pageHeader, "Manuals and Forms");
        }

        public static void NavigateToMDSAdhocReports()
        {
            Driver.ClickOn(SidebarMenu.mdsAdhocButton);
            VerifyElement.AreEqual(MDSAdhocPage.pageHeader, "MDS Ad-hoc Reports");
        }

        public static void NavigateToBilling()
        {
            Driver.ClickOn(SidebarMenu.billingButton);
        }

        //public static void NavigateToReimbursement()
        //{
        //Driver.ClickOn(SidebarMenu.);
        //}

        public static void NavigateToQualityMeasures()
        {
            Driver.ClickOn(SidebarMenu.quailityMeasuresButton);
        }

        //public static void NavigateToQualityMeasuresLongStayDetails()
        //{
        //    Driver.ClickOn(SidebarMenu.);
        //}



        #endregion

    }
}