using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class CQ__WIP___View_Resident_History_by_resident_name__RN__circle_button : BaseSetup
    {
        [Test]
        public void CQ_WIP___View_Resident_History_by_resident_name__RN__circle_button()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  Click Residents Name(RN) in the circle button on the Residents Tiles for any resident on the First page
            Driver.ClickOn(By.XPath("(//span[@class='initials-text ng-binding'])[1]"));
            //Step 3  Click User profile
            Driver.ClickOn(UserMenu.userIcon);
            //Step 4  Click WIP tile
            Driver.ClickOn(UserMenu.wipIcon);
            //Step 5  Click Residents Name(RN) in the circle button on the Residents Tiles for any resident on the Last page
            Driver.ClickOn(By.XPath("(//li[@class='pagination-page ng-scope']/a)[last()]"));
            Driver.ClickOn(By.XPath("(//span[@class='initials-text ng-binding'])[1]"));
            //Step 6  Click User profile
            Driver.ClickOn(UserMenu.userIcon);
            //Step 7  Click WIP tile
            Driver.ClickOn(UserMenu.wipIcon);
            //Step 8  Click Residents Name(RN) in the circle button on the Residents Tiles for any resident on the Second page
            Driver.ClickOn(SchedulePage.twoPagination);
        }
    }
}
