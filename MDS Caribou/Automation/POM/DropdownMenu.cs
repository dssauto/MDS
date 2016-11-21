using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class DropdownMenu
    {
        #region WebElements

        static internal By accountSettingsLink = By.XPath("//a[@href='/menu/useraccountsettings']");
        static internal By scheduleIcon = By.XPath("//ul/li/label[contains(., 'Schedule')]");
        static internal By wipIcon = By.XPath("//ul/li/label[contains(., 'WIP')]");
        static internal By historyIcon = By.XPath("//ul/li/label[contains(., 'History')]");
        static internal By batchTransmitIcon = By.XPath("//ul/li/label[contains(., 'Batch & Transmit')]");
        static internal By reportsFormsIcon = By.XPath("//ul/li/label[contains(., 'Reports & Forms')]");
        static internal By adminIcon = By.XPath("//ul/li/label[contains(., 'Admin')]");
        static internal By userIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[4]/div[1]/img");
        static internal By signoutButton = By.XPath("//button[normalize-space(text())='Sign Out']");


        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("");
        }
        public static void SignOut()
        {
        }
        #endregion

        #region Navigation

        public static void NavigateTo()
        {
        }
        #endregion
    }
}
