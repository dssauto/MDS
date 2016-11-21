using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class FacilitySettingsPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By adminNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By facilitySettingsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");

        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");
        static internal By saveButton = By.XPath("//*[@id='main-content']/div/header/div/button");

        //Care Areas
        static internal By careAreasLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[1]/label");
        static internal By useCareAreaAssessementsCheckBox = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[1]/div/label");
        static internal By npiTextfield = By.Id("NPI");
        static internal By ccnTextfield = By.Id("CCN");
        static internal By spnTextfield = By.Id("SPN");
        static internal By aitcTextfield = By.Id("subID");

        //Setting
        static internal By settingLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[2]/label");
        static internal By urbanCheckBox = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[2]/div[1]/label");
        static internal By ruralCheckBox = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[2]/div[2]/label");

        //Facility Provider Numbers
        static internal By facilityProviderNumbersLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[3]/label");
        static internal By npiLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[3]/div/div[1]/label");
        static internal By ccnLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[3]/div/div[2]/label");
        static internal By spnLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[3]/div/div[3]/label");

        //AITC
        static internal By aitcLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[4]/label");
        static internal By subIDLabel = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div[4]/div/div/label");
        static internal By subIDTextField = By.Id("subID");
        static internal By typeOfProviderLabel = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/div[1]/label");
        static internal By nursingHomeCheckBox = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/div[1]/div[1]/label");
        static internal By swingBedCheckBox = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/div[1]/div[2]/label");
        static internal By submissionRequirementLabel = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/div[2]/label");
        static internal By option1CheckBox = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/div[2]/div[1]/label/span");
        static internal By option2CheckBox = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/div[2]/div[2]/label/span");
        static internal By option3CheckBox = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div/div[2]/div[3]/label/span");

        //Assessment Settings
        static internal By assessmentSettingsLabel = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div/label");
        static internal By quarterlyAssessmentLabel = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div/div/div[1]/label");
        static internal By quarterlyAssessmentScrollBar = By.XPath("//*[@id='Quarterly']/div/a");
        static internal By annualAssessmentLabel = By.XPath("//*[@id='main-content']/div/div/div[3]/div/div/div/div/div[2]/label");
        static internal By annualAssessmentScrollBar = By.XPath("//*[@id='main-content']/div/div/div[3]/div[1]/div/div/div/div[2]/ul/li[2]/div/a");

        //Bottom
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");


        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.AreEqual(pageHeader, "Facility Settings");
            VerifyElement.IsPresent(saveButton);

            //Care Areas
            VerifyElement.AreEqual(careAreasLabel, "Care Areas");
            VerifyElement.IsPresent(useCareAreaAssessementsCheckBox);

            //Setting
            VerifyElement.AreEqual(settingLabel, "Setting");
            VerifyElement.IsPresent(urbanCheckBox);
            VerifyElement.IsPresent(ruralCheckBox);

            //Facility Provider Numbers
            VerifyElement.AreEqual(npiLabel, "A. National Provider Identifier (NPI)");
            VerifyElement.IsPresent(npiTextfield);
            VerifyElement.AreEqual(ccnLabel, "B. CMS Certification Number (CCN)");
            VerifyElement.IsPresent(ccnTextfield);
            VerifyElement.AreEqual(spnLabel, "C. State Provider Number");
            VerifyElement.IsPresent(spnTextfield);

            //AITC
            VerifyElement.AreEqual(aitcLabel, "AITC");
            VerifyElement.AreEqual(subIDLabel, "Assigned Facility/Provider Submission Id");
            VerifyElement.IsPresent(subIDTextField);
            VerifyElement.AreEqual(typeOfProviderLabel, "A0200. Type of Provider");
            VerifyElement.IsPresent(nursingHomeCheckBox);
            VerifyElement.IsPresent(swingBedCheckBox);
            VerifyElement.AreEqual(submissionRequirementLabel, "A0410. Submission Requirement");
            VerifyElement.IsPresent(option1CheckBox);
            VerifyElement.IsPresent(option2CheckBox);
            VerifyElement.IsPresent(option3CheckBox);

            //Assessment Settings
            VerifyElement.AreEqual(assessmentSettingsLabel, "Assessment Settings");
            VerifyElement.AreEqual(quarterlyAssessmentLabel, "Quarterly Assessment");
            VerifyElement.IsPresent(quarterlyAssessmentScrollBar);
            VerifyElement.AreEqual(annualAssessmentLabel, "Annual Assessment");
            VerifyElement.IsPresent(annualAssessmentScrollBar);

            //Bottom
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.IsPresent(developedByFooter);
        }
        #endregion

        #region Navigation


        #endregion
    }
}