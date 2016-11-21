using Framework.Helper;
using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class LoginPage
    {
        #region WebElements
        static internal By pageHeader = By.XPath("//div[@class='col-lg-12 logo']/h1");
        static internal By emailTextField = By.Id("inputEmail");
        static internal By forgotPasswordEmailTextField = By.Id("email");
        static internal By passwordTextField = By.Id("inputPassword");
        static internal By loginBtn = By.XPath("//button[contains(.,'Login')]");

        static internal By selectFacilityDropdown = By.Id("location");
        static internal By signinButton = By.XPath("//button[@type='submit']");
        static internal By signinButtonDisabled = By.XPath("//*[@id='main-content']/div[2]/button");
        static internal By loginLink = By.XPath("//div/a[contains(., 'Login')]");
        static internal By submitButton = By.XPath("//button[contains(., 'Submit')]");
        static internal By forgotPasswordorExpiredLink = By.XPath("//a[@href='/CaribouCLCSuite/forgotpassword']");
        static internal By forgotPasswordLable = By.XPath("//div/span[@class='lead']");
        static internal By footerCaribou = By.XPath("//*[@id='footer']/span[1]");
        static internal By footerVersion = By.XPath("//*[@id='footer']/span[2]");
        static internal By footerCopyright = By.XPath("//*[@id='footer']/span[4]");
        static internal By firstnameTextfield = By.Id("inputFirstName");
        static internal By lastnameTextfield = By.Id("inputLastName");
        static internal By registerButton = By.XPath("(//button[normalize-space(text())='Register'])[1]");
        static internal By requestAccessButton = By.XPath("//*[@id='main-content']/div[4]/button");
        static internal By welcomeMessage = By.XPath("//p[@class='lead ng-binding']");
        static internal By warningMessage = By.XPath("//*[@id='toast-container']/div/div[2]");
        static internal By bottomWarningMessage = By.XPath("//*[@id='main-content']/div[4]/p[1]");
        static internal By submittedMessage = By.XPath("//*[@id='mds']/div[1]/div/div/div/div/div/div[4]/p[1]");

        #endregion

        #region Actions
        internal static void CreateNewUser(string facility)
        {
            Driver.InsertText(LoginPage.emailTextField, RandomNameHelper.RandomString(8) + "@mail.com");
            Driver.InsertText(LoginPage.passwordTextField, "Test1234!");
            Driver.ClickOn(By.XPath("//*[@id='location']/option[normalize-space(text())='" + facility + "']"));
            Driver.ClickOn(LoginPage.registerButton);
            Driver.InsertText(LoginPage.firstnameTextfield, "FirstName");
            Driver.InsertText(LoginPage.lastnameTextfield, "LastName");
            Driver.ClickOn(LoginPage.registerButton);
            Driver.InsertText(LoginPage.passwordTextField, "Test1234!");
            Driver.ClickOn(LoginPage.requestAccessButton);
        }
        public static void SubmitForgotPassword(string emailLocator, string faclityLocator)
        {
            NavigateToForgotPasswordorExpired();
            Driver.InsertText(forgotPasswordEmailTextField, emailLocator);
            Driver.SelectDropdown(selectFacilityDropdown, faclityLocator);
            Driver.PressEnter(submitButton);
            VerifyElement.AreEqual(submittedMessage, "Your request is submitted.");
            Driver.ClickOn(loginLink);
        }
        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite Login");
            VerifyElement.AreEqual(pageHeader, "Caribou CLC Suite");
            VerifyElement.IsPresent(emailTextField);
            VerifyElement.IsPresent(passwordTextField);
            VerifyElement.IsPresent(selectFacilityDropdown);
            VerifyElement.IsPresent(signinButtonDisabled);
            VerifyElement.AreEqual(forgotPasswordorExpiredLink, "Forgot Password or Expired?");
            VerifyElement.AreEqual(footerCaribou, "Caribou CLC Suite");
            VerifyElement.IsPresent(footerVersion);
            VerifyElement.AreEqual(footerCopyright, "Developed by DSS, Inc. © 2016");
        }
        public static void SignIn()
        {
            String access = ConfigurationManager.AppSettings["Access"];
            String verify = ConfigurationManager.AppSettings["Verify"];
            String facility = ConfigurationManager.AppSettings["Facility"];
            // Steps to login
            Driver.InsertText(emailTextField, access);
            Driver.InsertText(passwordTextField, verify);
            Driver.ClickOn(By.XPath("//*[@id='location']/option[normalize-space(text())='" + facility + "']"));
            Driver.ClickOn(signinButton);
            Driver.WaitForPageLoad();
            VerifyElement.AreEqual(footerCaribou, "Caribou CLC Suite");
        }
        public static void Login()
        {
            String access = ConfigurationManager.AppSettings["Access"];
            String verify = ConfigurationManager.AppSettings["Verify"];
            String facility = ConfigurationManager.AppSettings["Facility"];
            // Steps to login
            Driver.InsertText(emailTextField, access);
            Driver.InsertText(passwordTextField, verify);
            Driver.ClickOn(By.XPath("//*[@id='location']/option[normalize-space(text())='" + facility + "']"));
            Driver.ClickOn(loginBtn);
            Driver.ClickOn(signinButton);
            Driver.WaitForPageLoad();
            VerifyElement.AreEqual(footerCaribou, "Caribou CLC Suite");
        }
        public static void SignInManually(string email, string password, string facility)
        {
            // Steps to login
            Driver.InsertText(emailTextField, email);
            Driver.InsertText(passwordTextField, password);
            Driver.Instance.FindElement(By.XPath("//*[@id='location']/option[normalize-space(text())='" + facility + "']")).Click();
            Driver.ClickOn(signinButton);
            Driver.WaitForPageLoad();
            VerifyElement.AreEqual(footerCaribou, "Caribou CLC Suite");
        }
        public static void Register(string email, string password, string first, string last, string facility)
        {
            Driver.ClickOn(registerButton);
            Driver.InsertText(emailTextField, email);
            Driver.InsertText(passwordTextField, password);
            Driver.InsertText(firstnameTextfield, first);
            Driver.InsertText(lastnameTextfield, last);
            Driver.SelectDropdown(selectFacilityDropdown, facility);
            Driver.ClickOn(registerButton);
            VerifyElement.AreEqual(warningMessage, "The username is already in use. Please enter a unique user name");
        }
        #endregion

        #region Navigation
        public static void NavigateToForgotPasswordorExpired()
        {
            Driver.PressEnter(forgotPasswordorExpiredLink);
            VerifyElement.AreEqual(forgotPasswordLable, "Forgot Password?");
        }
        public static void NavigateToLoginPage()
        {
            Driver.ClickOn(loginLink);
            VerifyElement.AreEqual(forgotPasswordorExpiredLink, "Forgot Password or Expired?");
        }
        #endregion
    }
}
