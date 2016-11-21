using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class UserAccountPage
    {
        #region PageElements

        static internal By browseButton = By.Id("picture");
        static internal By currentPasswordTextfield = By.Id("currentPassword");
        static internal By newPasswordTextfield = By.Id("newPassword");
        static internal By confirmNewPasswordTextfiled = By.Id("confirmNewPassword");
        static internal By changePasswordButton = By.XPath("//button[@class='btn btn-warning btn-sm']");
        static internal By redWarning = By.XPath("//small[@class='red']");

        #endregion
    }
}
