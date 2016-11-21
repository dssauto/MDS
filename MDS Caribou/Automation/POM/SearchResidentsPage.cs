using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class SearchResidentsPage
    {
        #region WebElements
        static internal By auditTrail = By.XPath("(//a[@class='ng-scope'])[5]");
        static internal By archive = By.XPath("(//a[@class='ng-scope'])[4]");
        static internal By changeItemSet = By.XPath("(//a[@class='ng-scope'])[3]");
        static internal By actionInactiveBtn = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div/div/div[2]/div[2]/button");
        static internal By lastPageNumber = By.XPath("(//li[@class='pagination-page ng-scope']/a)[last()]");
        static internal By secondPage = By.XPath("(//li[@class='pagination-page ng-scope active']/a)[contains(., '2')]");
        static internal By firstResidentTile = By.XPath("//li[@class='list-group-item ng-scope'][1]");
        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLCSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By searchResidentsIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span/i");
        static internal By searchResidentsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");

        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");
        static internal By residentsSearchTextField = By.Id("searchResidents");
        static internal By selectLocationDropdown = By.Id("selectLocation");
        static internal By searchButton = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div/div/div[3]/button");
        static internal By typeToSearchForResidentsMessage = By.XPath("//*[@id='main-content']/div/div[2]/div/div/div/div/div/p[1]");
        static internal By orFilterByNeighborhoodMessage = By.XPath("//*[@id='main-content']/div/div[2]/div/div/div/div/div/p[2]");

        static internal By hintMessage = By.XPath("//*[@id='main-content']/div/div[2]/div/div/div/div/div/small");
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");
        static internal By searchResultLastname = By.XPath("(//h3[@class='name ng-binding'])[1]");
        static internal By searchResultFirstname = By.XPath("(//h3[@class='name ng-binding'])[2]");
        static internal By neighborhood = By.XPath("(//p[@class='ng-binding']/i[@class='fa fa-map-marker'])[1]");
        static internal By roomandBed = By.XPath("(//p[@class='ng-binding']/i[@class='fa fa-bed'])[1]");
        static internal By lastSSN = By.XPath("(//p[@class='ng-binding'])[2]");
        static internal By noMatchMsg = By.XPath("(//p[@class='lead ng-scope'])[1]");

        #endregion

        #region Action
        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.IsPresent(caribouCLCSuiteNavbar);
            VerifyElement.IsPresent(searchResidentsIcon);
            VerifyElement.IsPresent(searchResidentsNavbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Search Residents");
            VerifyElement.IsPresent(residentsSearchTextField);
            VerifyElement.IsPresent(selectLocationDropdown);
            VerifyElement.IsPresent(searchButton);
            VerifyElement.AreEqual(typeToSearchForResidentsMessage, "Type to Search for residents");
            VerifyElement.AreEqual(orFilterByNeighborhoodMessage, "or filter by Neighborhood");
            VerifyElement.AreEqual(hintMessage, "Hint: type last name then first name separated by space");
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.IsPresent(developedByFooter);
        }
        internal static void FindResidentWithAssessment()
        {
            for (int i = 1; i < 8; i++)
            {
                Driver.ClickOn(SearchResidentsPage.searchButton);
                Driver.ClickOn(By.XPath("(//li[@class='list-group-item ng-scope'])[" + i + "]"));
                Driver.WaitFor(2);
                if (Driver.IsElementPresent(By.XPath("(//div[@class='iradio_square-blue'])[1]")))
                {
                    break;
                }
                Browser.GoBack();
            }
        }
        #endregion

        #region Navigation

        public static void NavigateToResidentsHistoryPage()
        {
            Driver.ClickOn(firstResidentTile);
            Driver.WaitFor(1);
            VerifyElement.AreEqual(ResidentsHistoryPage.pageHeader, "Resident's History");
        }
        public static void NavigateToLastPage()
        {
            if (Driver.IsElementPresent(lastPageNumber))
            {
                Driver.ClickOn(lastPageNumber);
            }
            else
            {
                Driver.ClickOn(By.XPath("//li[@class='pagination-page ng-scope active']/a"));
            }

        }
        internal static void NavigateToSecondPage()
        {
            if (Driver.IsElementPresent(secondPage))
            {
                Driver.ClickOn(secondPage);
            }
            else
            {
                Driver.ClickOn(By.XPath("//li[@class='pagination-page ng-scope active']/a"));
            }
        }

        #endregion

    }
}