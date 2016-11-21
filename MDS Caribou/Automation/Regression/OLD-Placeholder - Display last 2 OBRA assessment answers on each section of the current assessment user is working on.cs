using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class OLD_Placeholder___Display_last_2_OBRA_assessment_answers_on_each_section_of_the_current_assessment_user_is_working_on
    {
        [Test]
        public void OLD_Placeholder_Display_last_2_OBRA_assessment_answers_on_each_section_of_the_current_assessment_user_is_working_on()
        {
            Browser.Open();
            LoginPage.SignIn();
            //VistA Required
            //Step 2  "Enter a Valid Access Code and Verify Code in respective Access Code and Verify Code boxes.
            //Log in as Nurse,One"
            //Step 3  Click Logon To VistA.
            //Step 7  Division selected.  Click Log On to VistA.
            //Step 4  "Caribou CLC Suite is displayed in upper left hand corner and Users name is displayed in upper right hand corner.
            //Tiles displayed for users permissions:  Logged in as Nurse - WIP displayed."
            //Step 5  Select Work in Progress Tile.
            //Step 6  Select a resident with a Qtr 1, Qtr 2, Qtr 3, Annual or Significant Change assessment due.
            //Step 8  "Select Open WIP to the left of assessment selected.  
            //Eg.Qtr 2."
            //Step 9  Select Section B from left side menu.
            //Step 10 Select Section History button from menu bar on bottom right hand of page.
            //Step 11 "Verify last two OBRA assessments are displayed.
            //IE: Admission & Qtr 1"
            //Step 12 "Verify data included:
            //ARD of assessments.
            //Type of assessments.
            //Section question answers."
            //Step 13 Verify Section B can be answered and fly out remains open.
            //Step 14 Make note of prior assessments and answers displayed.Click check to close fly out.
            //Step 15 Select Caribou CLC Suite breadcrumb in upper left hand corner.
        }
    }
}
