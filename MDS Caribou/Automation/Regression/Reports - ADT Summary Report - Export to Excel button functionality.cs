using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Automation.Regression
{
    [TestFixture]
    class Reports___ADT_Summary_Report___Export_to_Excel_button_functionality
    {
        [Test]
        public void TestName()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select the Reports and Forms Tile.
            //Step 2  While in the Reports and Forms Tile with the Dashboard menu option selected, scroll to the bottom of the dashboard page and select the ADT Report Summary button.
            //Step 3  Select the Date selection button on the ADT Report.
            //Step 4  "In the ""From"" calendar, select a From Date that is 4 days prior to todays date. 
                      //Example: is todays date is 8 / 23 / 2016 the user would select 8 / 19 / 2016 in the ""From"" Calendar."
            //Step 5  In the "To" calendar, select todays Date if not already selected.
            //Step 6  Click the Apply Button.
            //Step 7  Click the Excel button on the bottom left of the report.
            //Step 8  Click the Save button.
            //Step 9  Click the Open button.
            //Step 10 Verify that the Excel sheet matches that of the ADT Summary Report on the Caribou MDS Application.
        }
    }
}
