using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class FD___Create_modification_and_verify_accuracy
    {
        [Test]
        public void FD_Create_modification_and_verify_accuracy()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            //Step 2  Click SEARCH button
            //Step 3  Select resident tile from the FIRST page with Sealed and Accepted assessment.
            //Step 4  Select the radio button to to the left of Sealedand Accepted assessment.
            //Step 5  Select Modification from Action drop down.
            //Step 6  Click YES button
            //Step 7  Select the radio button modificated assessment.
            //Step 8  Select Edit from Action drop down.
            //Step 9  Verify that modificated assessment has Section from A to Z
            //Step 10 Select Section A
            //Step 11 Verify that A0050 Type of Record has active radio button number 2 "Modify existing record"
            //Step 12 Select Section X
        }
    }
}
