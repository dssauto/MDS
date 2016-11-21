using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class CMS802Page
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By reportsFormsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By cms802Navbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/header/h1");
        static internal By printButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[1]/button");
        static internal By instructionsButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[1]/a");
        static internal By addRowButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[1]");
        static internal By saveButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[2]");
        static internal By selectExistingButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[3]");
        static internal By noCurrentReportMessage = By.XPath("//*[@id='divToPrint']/div/div/table/tbody/tr/td");
        static internal By createNewButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[4]");
        static internal By informationMessage = By.XPath("//*[@id='main-content']/div/div/div[1]/div/p");
        static internal By selectReportFromListHeader = By.XPath("//*[@id='mds']/div[1]/div/div/div[1]/h3");

        //Neighborhoods
        static internal By neighborhoodsHeader = By.XPath("//*[@id='mds']/div[1]/div/div/div[1]/h3");
        static internal By selectNeighborhoodLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div/div/label");
        static internal By selectNeighborhoodDropdown = By.Id("selectNeighborhood");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/button[1]");
        static internal By confrimButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/button[2]");

        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.IsPresent(reportsFormsNavbar);
            VerifyElement.IsPresent(cms802Navbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "CMS-802 Roster/Sample Matrix");
            VerifyElement.IsPresent(printButton);
            VerifyElement.IsPresent(instructionsButton);
            VerifyElement.IsPresent(addRowButton);
            VerifyElement.IsPresent(saveButton);
            VerifyElement.IsPresent(selectExistingButton);
            VerifyElement.IsPresent(createNewButton);
            VerifyElement.AreEqual(informationMessage, "All information entered by computer should be verified by a staff member knowledgeable about the resident population.");

            //Neighborhoods
            VerifyElement.AreEqual(neighborhoodsHeader, "Neighborhoods");
            VerifyElement.AreEqual(selectNeighborhoodLabel, "Select Neighborhood");
            VerifyElement.IsPresent(selectNeighborhoodDropdown);
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(confrimButton);

            VerifyElement.AreEqual(noCurrentReportMessage, "(No Current Report)");
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.IsPresent(developedByFooter);
        }

        #endregion

        #region Navigation

        public static void NavigateToNeighborhoods()
        {
            Driver.ClickOn(CMS802Page.createNewButton);
            VerifyElement.AreEqual(neighborhoodsHeader, "Neighborhoods");
        }

        public static void NavigateToSelectReportFromList()
        {
            Driver.ClickOn(CMS802Page.selectExistingButton);
            VerifyElement.AreEqual(selectReportFromListHeader, " Select report from list");
        }
        #endregion

    }
}