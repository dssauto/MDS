using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class AssessmentPage
    {
        #region WebElements
        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By sectionALink = By.XPath("//a[contains(.,'Section A')]");
        static internal By sectionZLink = By.XPath("//a[contains(.,'Section A')]");
        static internal By sectionHeader = By.XPath("(//h2)[1]");
        static internal By a0100A = By.Id("A0100A");
        static internal By a0100B = By.Id("A0100B");
        static internal By a0100C = By.Id("A0100C");
        #endregion

        #region Action
        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(homeIcon);
        }

        #endregion

        #region Navigation

        public static void NavigateToSectionA()
        {
            Driver.ClickOn(sectionALink);
            VerifyElement.AreEqual(sectionHeader, "Section A");
        }
        #endregion
    }
}
