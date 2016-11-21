using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class FC___Create_Inactivation_and_verify_accuracy
    {
        [Test]
        public void FC_Create_Inactivation_and_verify_accuracy()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            //Step 2  Click SEARCH button
            //Step 3  Select resident tile from the FIRST page with Sealed and Accepted assessment.
            //Step 4  Select the radio button to to the left of Sealed and Accepted assessment.
            //Step 5  Select Inactivation from Action drop down.
            //Step 6  Click YES button
            //Step 7  Select the radio button Inactivated assessment.
            //Step 8  Select Edit from Action drop down.
            //Step 9  Verify that Inactivated assessment has only Section A, Section X
            //Step 10 Select Section A
            //Step 11 Verify that A0050 Type of Record has active radio button number 3 "inactivate existing record"
        }
    }
}
