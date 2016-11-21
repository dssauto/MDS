   
Reference Section
________________________________________________________________________________________________________________
 <Reference Include="nunit.framework, Version=3.4.1.0, Culture=neutral, PublicKeyToken=2638cd05610744eb, processorArchitecture=MSIL">
 	<HintPath>..\Framework\Framework\packages\NUnit.3.4.1\lib\net45\nunit.framework.dll</HintPath>
      	<Private>True</Private>
</Reference>
<Reference Include="WebDriver, Version=2.53.1.0, Culture=neutral, processorArchitecture=MSIL">
      	<HintPath>..\Framework\Framework\packages\Selenium.WebDriver.2.53.1\lib\net40\WebDriver.dll</HintPath>
      	<Private>True</Private>
</Reference>
<Reference Include="WebDriver.Support, Version=2.53.1.0, Culture=neutral, processorArchitecture=MSIL">
      	<HintPath>..\Framework\Framework\packages\Selenium.Support.2.53.1\lib\net40\WebDriver.Support.dll</HintPath>
      	<Private>True</Private>
</Reference>
________________________________________________________________________________________________________________



Class Section
________________________________________________________________________________________________________________
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation
{
    [TestFixture]
    public class Class1: BaseSetup
    {
        [Test]
        public void Test1()
        {
            Browser.Open();
        }
    }
}
________________________________________________________________________________________________________________


POM Region
________________________________________________________________________________________________________________
using Framework.POM;
using OpenQA.Selenium;



        #region WebElements

        static internal By pageHeader = By.XPath("");
        static internal By TextField = By.XPath("");
        static internal By Button = By.XPath("");
        static internal By Link = By.XPath("");
        static internal By Icon = By.XPath("");
        static internal By Dropdown = By.XPath("");
        static internal By Lable = By.XPath("");
        static internal By ColumnLable = By.XPath("");
        static internal By Pagination = By.XPath("");
        static internal By Message = By.XPath("");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("");
            VerifyElement.AreEqual(pageHeader, "");
        }
        #endregion

        #region Navigation

        public static void NavigateTo()
        {
        }
        #endregion
________________________________________________________________________________________________________________


UI Test
________________________________________________________________________________________________________________
using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class LoginPageTest: BaseSetup
    {
        [Test]
        public void TC001_LoginPage_SigninValidation()
        {
            //Step 1
            Browser.Open();
            //Step 2
            LoginPage.SignIn();
        }
    }
}
________________________________________________________________________________________________________________


XPath
________________________________________________________________________________________________________________

//button[normalize-space(text())='Sign In']
//button[contains(., 'Save')]
(//button[@id='dropdownMenu1'])[2]

//input[@value='Save']

//th[contains(., 'Description')]
//th[normalize-space(text())='Description']

//a[@href='/MCCDashboardTest/ReleaseNotes']

//tr[10]/td[2][normalize-space(text())='Discussion Topic']

//tr/td[normalize-space(text())='Labs/Procedures']//following-sibling::td[2][normalize-space(text())='Immediately']

//tbody/tr[2]/td[2][contains(., 'Abc Automation')]//preceding-sibling::td[1]/input
//ul[@class=' ']/li[contains(., ' ')]


________________________________________________________________________________________________________________


Driver
________________________________________________________________________________________________________________

	Driver.WaitFor(2);
	Driver.WaitForElement(locator);
	Driver.ClickOn(locator);
	Driver.ClickRadioButton(locator);
	Driver.PressEnter(locator);
	Driver.InsertText(locator, "");
	Driver.SelectDropdown(locator, "");

	VerifyElement.AreEqual(locator, "");
	VerifyElement.IsPresent(locator);
	VerifyElement.TitleIsPresent("");
	VerifyElement.ButtonIsDisabled(locator);

	Browser.Open();
	Browser.Close();
	Browser.Maximize();
	Browser.GoBack();
	Browser.SwitchToWindow();
	Browser.SwitchToParent();
	Browser.RefreshPage();









