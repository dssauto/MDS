using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class DD___Resident_History___Action_Dropdown_menu___Audit_Trail_selection_Functionality : BaseSetup
    {
        [Test]
        public void DD_Resident_History_Action_Dropdown_menu_Audit_Trail_selection_Functionality()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click SEARCH button
            //Step 3  Select resident tile from the FIRST page(except Sealed and Pending)
            SearchResidentsPage.FindResidentWithAssessment();
            //Step 4  Select the radio button to to the left of any assessment.
            Driver.ClickOn(By.XPath("(//div[@class='iradio_square-blue'])[1]"));
            //Step 5  Select Audit Trail from Action drop down.
            Driver.ClickOn(SearchResidentsPage.actionInactiveBtn);
            Driver.ClickOn(SearchResidentsPage.auditTrail);
            //Step 6  Click CLOSE button
            Driver.ClickOn(By.XPath("//button[@ng-click='close()']"));
            //Step 7  Click Search resident link
            Driver.WaitFor(1);
            Driver.ClickOn(UserMenu.searchResidentsNavbarLink);
            //Step 8  Click SEARCH button
            //Step 9  Select resident tile with Sealed and Pending assessment
            SearchResidentsPage.FindResidentWithAssessment();
            Driver.ClickOn(By.XPath("(//div[@class='iradio_square-blue'])[1]"));
            //Step 10 Select Audit Trail for a Resident that has a Sealed assessment which is pendingfrom Action drop down.
            Driver.ClickOn(SearchResidentsPage.actionInactiveBtn);
            Driver.ClickOn(SearchResidentsPage.auditTrail);
            //Step 11 Click CLOSE button
            Driver.ClickOn(By.XPath("//button[@ng-click='close()']"));
        }
    }
}
