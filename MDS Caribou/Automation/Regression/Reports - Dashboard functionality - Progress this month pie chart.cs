using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]

    class Reports___Dashboard_functionality___Progress_this_month_pie_chart
    {
        [Test]
        public void Reports_Dashboard_functionality___Progress_this_month_pie_chart()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  "PRECONDITION: 
            //1.Create a new facility as to have a controlled enviroment for validating the counts of the Reports and Forms page.
            //2.Have 2 assessments in Progress.
            //3.Have 2 assessment completed.
            //4.Have 1 Sealed assessment.
            //5.Have 2 seperate batches."
            //Step 2  Select Reports & Forms Tile.
            //Step 3  In the "Progress this Month" pie chart, verify that the Assessments in Progress, Completed Assessments this month, Sealed Assessments this month, and Batched Assessments this month counts match that that in the pie chart when you hover the mouse over each section of the pie graph.
            //Step 4  Verify the colors of the pie chart match that to their coorsponding tiles above.
        }
    }
}
