using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class Reports___Dashboard_functionality___Assessments_By_Month_Line_Graph
    {
        [Test]
        public void Reports_Dashboard_functionality___Assessments_By_Month_Line_Graph()
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
        }
    }
}
