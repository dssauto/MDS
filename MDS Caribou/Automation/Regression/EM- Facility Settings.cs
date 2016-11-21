using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using System;

namespace Automation.Regression
{
    [TestFixture]
    class EM_Facility_Settings : BaseSetup
    {
        [Test]
        public void EM_FacilitySettings()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  'Log in as Facility Administrator.
            //Step 2   Select Admin tile > Facility Settings from left hand menu.
            //LandingPage.NavigateToAdminPage();
            //AdminPage.NavigateToFacilitySettings();
            ////Step 3  "Setting Select the Urban radio button."
            //if (Driver.IsElementPresent(By.XPath("//input[@value='Urban' and @aria-checked='false']")))
            //{
            //    Driver.ClickOn(By.XPath("(//div[@class='iradio_square-blue'])[1]"));
            //}
            ////Step 4  "Facility Provider Numbers
            ////Enter 99 for National Provider Identifier
            //Driver.InsertText(FacilitySettingsPage.npiTextfield, "99");
            ////Enter 02 for CMS Certification Number
            //Driver.InsertText(FacilitySettingsPage.ccnTextfield, "02");
            ////Enter 5619AA for State Provider Number"
            //Driver.InsertText(FacilitySettingsPage.spnTextfield, "5619AA");
            ////Step 5  "AITC
            ////Enter VHAFL5619AA Assigned Facility / Provider Submission ID."
            //Driver.InsertText(FacilitySettingsPage.aitcTextfield, "VHAFL5619AA");
            ////Step 6  "A0200. Type of Provider
            ////Select the 1.Nursing home(SNF / NF) radio button."
            //if (Driver.IsElementPresent(By.XPath("//input[@id='NursingHome' and @aria-checked='false']")))
            //{
            //    Driver.ClickOn(By.XPath("(//div[@class='iradio_square-blue'])[2]"));
            //}
            ////Step 7  "A0410. Submission Requirement
            ////Select the 3.Unit is Medicare and / or Medicaid certified radio button."
            //Driver.ClickOn(By.XPath("//input[@id='Certified']//parent::div"));
            ////Step 8  "Assessment Settings
            ////Quarterly Assessment
            ////Change slider bar to 80 days
            ////Annual Assessment
            ////Change slider bar to 355 days"
            ////Step 9  Click SAVE
            //Driver.ClickOn(FacilitySettingsPage.saveButton);
            ////Step 10 Verify all settings on the Facility Settings page are still displayed to what was entered in the previous steps.
            //VerifyElement.AreEqual(By.XPath("//*[@id='toast-container']/div/div[2]"), "Saved successfully");
            ////Step 11 Select Caribou CLC Suite from left upper hand corner breadcrumb.
            //Driver.ClickOn(UserMenu.caribouCLCSuiteBreadcrumb);
            //Step 12 Select Schedule tile.

            LandingPage.NavigateToSchedulePage();
            //"Verify OBRA assessments display 80 days between Admission > Quarterly > Quarterly > Annual by moving slider bar out to 370 to see all assessment due for a resident and selecting one resident from Resident Search.
            Driver.ClickOn(SchedulePage.ppsFilterButtonChecked);
            SchedulePage.MoveSlider(120);
            SchedulePage.VerifyAdmissionToQ1DaysWithManualDays("RAIMDSRESIDENT, FOURTEEN F", 80);
            //Step 13 Verify that the Annual Assessment is NOT over 355 days after the Admission day."
            //Step 14 Select a resident with an Admission assessment due > Click CREATE MDS.
            SchedulePage.CreateMDSBy("Admission");
            SchedulePage.VistALogin();
            //"A2300. Assessment Reference Date (ARD):
            //Step 15 Change date to a different day(closer or farther to Admission Date by 2 days)."
            Driver.WaitFor(2);
            string fullDate = Driver.Instance.FindElement(SchedulePage.admissionDateCalendarData).Text.ToString();
            string m = fullDate.Substring(0, 2);
            string d = fullDate.Substring(3, 2);
            string y = fullDate.Substring(6, 4);
            string dUpdate = (Convert.ToInt32(d) + 2).ToString();
            string newDate = m + "-" + dUpdate + "-" + y;
            Driver.InsertText(SchedulePage.calendarARDTextfield, newDate);
            Driver.InsertText(SchedulePage.entryDateCalendarTextfield, fullDate);
            //Step 16 Click CREATE.
            Driver.ClickOn(SchedulePage.createNewMDSCreateBtnEnabled);
            //Step 17 Select Section A from left side menu.
            AssessmentPage.NavigateToSectionA();
            //Step 18 "Verify A0100. Facility Provider Numbers 
            //A.National Provider Identifier(NPI) is same as entered in facility settings(99)
            VerifyElement.AreEqual(AssessmentPage.a0100A, "99");
            //B.CMS Certification Number(CCN) is same as entered in facility settings(02)
            VerifyElement.AreEqual(AssessmentPage.a0100B, "02");
            //C.State Provider Number is same as entered in facility settings(5619AA)"
            VerifyElement.AreEqual(AssessmentPage.a0100C, "5619AA");
            //Step 19 Verify A0200.Type of Provider radio button 1.Nursing home(SNF / NF) is selected.
            //Step 20 Verify A0410.Unit Certification or Licensure Designation radio 3.Unit is Medicare and / or Medicaid certified is selected.
            //Step 21 Click Caribou CLC Suite bread crumb.
            //Step 22 Select Schedule tile.
            //"Select SAME resident from Resident Search box Admission created in above step to populate schedule with residents assessments.
            //Slide Due in slider bar to 370 days.
            //Step 23 Using new ARD from Admission OBRA created verify next Quarterly due is 80 days and Annual is NO MORE than 355 days."
        }
    }
}
