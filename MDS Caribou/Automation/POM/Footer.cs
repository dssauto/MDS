using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class Footer
    {
        #region WebElements
        static internal By footerCaribou = By.XPath("//*[@id='footer']/span[1]");
        static internal By footerVersion = By.XPath("//*[@id='footer']/span[2]");
        static internal By footerFacility = By.XPath("//*[@id='footer']/span[3]");
        static internal By footerCopyright = By.XPath("//*[@id='footer']/span[4]");
        #endregion

        #region Action
        public static void VerifyPageElements()
        {
            VerifyElement.AreEqual(footerCaribou, "Caribou CLC Suite");
            VerifyElement.IsPresent(footerVersion);
            VerifyElement.IsPresent(footerFacility);
            VerifyElement.AreEqual(footerCopyright, "Developed by DSS, Inc. © 2016");
        }
            #endregion

            #region Navigation
            #endregion
        }
}
