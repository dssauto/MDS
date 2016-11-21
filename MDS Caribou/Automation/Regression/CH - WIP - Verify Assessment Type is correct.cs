using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class CH___WIP___Verify_Assessment_Type_is_correct : BaseSetup
    {
        [Test]
        public void CH_WIP___Verify_Assessment_Type_is_correct()
        {
            Browser.Open();
            LoginPage.SignIn();
            //VistA Required
            //Step 1  Select Schedule tile
            //Step 2  Login to VistA
            //Step 3  Click CREATE MDS button for any resident
            //Step 4  Create New MDS Assessment
            //Step 5  Select Work In Progress tile.
            //Step 6  Find New MDS Assessment on the  Work In Progress page
            //Step 7  Verify that  Assessment Type has displayed correctly on Work In Progress page
        }
    }
}
