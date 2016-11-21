using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class SidebarMenu
    {
        #region WebElements
        // Navigation
        static internal By usersRolesLink = By.XPath("//div[@id='leftside-navigation']//span[text()='Users & Roles']");
        static internal By facilitySettingsLink = By.XPath("//div[@id='leftside-navigation']//span[text()='Facility Settings']");
        static internal By rugRatesLink = By.XPath("//div[@id='leftside-navigation']//span[text()='Rug Rates']");
        static internal By notificationLink = By.XPath("//div[@id='leftside-navigation']//span[text()='Notifications']");
        // Icons
        static internal By usersRolesIcon = By.XPath("//div[@id='leftside-navigation']//i[@class='fa fa-users fa-fw hidden-xs']");
        static internal By facilitySettingsIcon = By.XPath("//div[@id='leftside-navigation']//i[@class='fa fa-gears fa-fw hidden-xs']");
        static internal By rugRatesIcon = By.XPath("//div[@id='leftside-navigation']//i[@class='fa fa-dollar fa-fw hidden-xs']");
        static internal By notificationIcon = By.XPath("//div[@id='leftside-navigation']//i[@class='fa fa-bell-o fa-fw hidden-xs']");

        static internal By dashboardButton = By.XPath("//*[@id='leftside-navigation']/ul/li[1]/a");
        static internal By cms802Button = By.XPath("//*[@id='leftside-navigation']/ul/li[2]/a");
        static internal By quailityMeasuresButton = By.XPath("/*[@id='leftside-navigation']/ul/li[3]/a");
        static internal By mdsAdhocButton = By.XPath("//*[@id='leftside-navigation']/ul/li[4]/a");
        static internal By billingButton = By.XPath("//*[@id='leftside-navigation']/ul/li[5]/a");
        static internal By masterResidentListButton = By.XPath("//*[@id='leftside-navigation']/ul/li[6]/a");
        static internal By manualsFromsButton = By.XPath("//*[@id='leftside-navigation']/ul/li[7]/a");
        // Navbars
        static internal By adminNavbar = By.XPath("(//div[@id='navbar']//span[@class='ng-binding'])[1]");
        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("");
        }
        public static void SignIn()
        {
            String access = ConfigurationManager.AppSettings["Access"];
            String verify = ConfigurationManager.AppSettings["Verify"];
            String facility = ConfigurationManager.AppSettings["Facility"];
            // Steps to login
            //Driver.InsertTextBy(emailTextField, access);
            //Driver.InsertTextBy(passwordTextField, verify);
            //Driver.SelectDropDownBy(selectFacilityDropdown, facility);
            //Driver.PressEnterBy(signinButton);
        }
        #endregion

        #region Navigation
        public static void NavigateToUsersRoles()
        {
            Driver.ClickOn(usersRolesLink);
            VerifyElement.AreEqual(adminNavbar, "Facility Users");
        }
        public static void NavigateToFacilitySettings()
        {
            Driver.ClickOn(facilitySettingsLink);
            VerifyElement.AreEqual(adminNavbar, "Facility Settings");
        }
        public static void NavigateToRugRates()
        {
            Driver.ClickOn(rugRatesLink);
            VerifyElement.AreEqual(adminNavbar, "Rug Rates");
        }
        public static void NavigateToNotifications()
        {
            Driver.ClickOn(notificationLink);
            VerifyElement.AreEqual(adminNavbar, "Notifications");
        }
        #endregion

    }
}