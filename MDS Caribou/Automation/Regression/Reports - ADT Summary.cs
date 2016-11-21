using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class Reports___ADT_Summary
    {
        [Test]
        public void Reports_ADT_Summary()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Reports &Forms Tile.
            //Step 2  Click the Sync button in the top right corner of the MDS website.
            //Step 3  Click the "Connect" button.
            //Step 4  Enter the users access and verify code. 
                      //Click the OK button on the bottom right of the VistA sign on screen.
            //Step 5  Select the Cache cube in the local computer system tray and open the VistA Teminal window of the server the Caribou MDS website is linked to.
            //Step 6  Follow the attached document to admit a resident. 
                      //NOTE: Admit the resident on the "2 days ago date", the left grouping of ADT Summary bubbles as defined in step 6.
            //Step 7  Follow the attached document to Transfer the resident. 
                      //NOTE: Transfer the resident on the ""Yesterdays Date"" date,  the middle grouping of ADT Summary bubbles as defined in step 6.
            //Step 8  Follow the attached document to discharge the resident. 
                      //Note: Discharge the resident on the "Todays Date" date, the right grouping of ADT Summary bubbles.
            //Step 9  Exit the Cache Cube by selecting File > Exit.
            //Step 10 Click the Sync button in the upper right corner of the Caribou MDS application.
            //Step 11 Select the "Sync" button.
            //Step 12 Enter the Access and Verify codes for the user. 
                      //Click the Logon button.
            //Step 13 //In the grouping of the 
                      //"Two Days Ago" date, there are 3 bubbles displayed: 
                      //Admission. (with count)
                      //Discharge. (with count)
                      //Transfer.  (with count)
                      //Verify that in the "A" bubble displays the admission count as + 1(from whatever the number was there previously) for the admission created in step 8.
            //Step 14 In the grouping of the "Day before yesterdays" date, there are 3 bubbles displayed: 
                      //Admission. (with count)
                      //Discharge. (with count)
                      //Transfer.  (with count)
                      //Verify that in the "T" bubble displays the Transfer count as + 1(from whatever the number was there previously) for the Transfer created in step 9.
            //Step 15 In the grouping of the 
                      //"Yesterdays" date, there are 3 bubbles displayed: 
                      //Admission. (with count)
                      //Discharge. (with count)
                      //Transfer.  (with count)
                      //Verify that in the "D" bubble displays the Discharge count as + 1(from whatever the number was there previously) for the Discharge created in step 10.
        }
    }
}
