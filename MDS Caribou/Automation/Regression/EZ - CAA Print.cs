using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EZ___CAA_Print
    {
        [Test]
        public void EZ_CAA_Print()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Print the attached document in this step to Verify all 20 CAAs.
            //Step 2  Click the Schedule Tile.
            //Step 3  Enter the name of the resident to create an admission assessment on in the Search text box.
            //Step 4  Select the resident name from the dropdown menu.
            //Step 5  On the line item for the Admission assessment click the "Create Assessment" button.
            //Step 6  Select the correct coding for an NC item set.
                      //The NC item set coding is as follows:
                      //1.
                      //99.
                      //0.
                      //99.
            //Step 7  Click the "Create" button.
            //Step 8  Click Section V in the left hand navigation pane.
            //Step 9  Scroll down to V0200 A CAAs and Care Planning. 
                      //Click the CAA Summary button.
            //Step 10 "Enter data into the text box provided.
                      //Click the Print button."
            //Step 11 "Select Appropriate printer. 
                      //Select the Print button on the bottom of the Windwos Print Dialog.
                      //Verify the CAA Summary is printed on the selected printer.
                      //Verify the Header, Footer, Resident name, and ARD date is displayed."
            //Step 12 Click Cancel on the CAA summary on the Caaribou MDS Website.
            //Step 13 "Click the CAA button for 01. Delirium. 
                      //Verify the Delirium CAA is displayed."
            //Step 14 "Fill out each tab within the CAA. 
                      //Click the Print button."
            //Step 15 "Select Appropriate printer. 
                      //Select the Print button on the bottom of the Windwos Print Dialog.
                      //Verify the CAA Summary is printed on the selected printer.
                      //Verify the Header, Footer, Resident name, and ARD date is displayed."
            //Step 16 Click Cancel on the CAA summary on the Caaribou MDS Website.
            //Step 17 "Click the CAA button for 2. Cognitive Loss / Dementia. 
                      //Verify the Delirium CAA is displayed."
            //Step 18 "Fill out each tab within the CAA. 
                      //Click the TIU tab."
            //Step 19 "Fill out each tab within the CAA. 
                      //Click the Print button."
            //Step 20 "Select Appropriate printer. 
                      //Select the Print button on the bottom of the Windwos Print Dialog.
                      //Verify the CAA Summary is printed on the selected printer.
                      //Verify the Header, Footer, Resident name, and ARD date is displayed."
            //Step 21 Click Cancel on the CAA summary on the Caaribou MDS Website.
            //Step 22 "Click the CAA button for 03. Visual Function. 
                      //Verify the Delirium CAA is displayed."
            //Step 23 "Fill out each tab within the CAA. 
                      //Click the Print button."
            //Step 24 "Select Appropriate printer. 
                      //Select the Print button on the bottom of the Windwos Print Dialog.
                      //Verify the CAA Summary is printed on the selected printer.
                      //Verify the Header, Footer, Resident name, and ARD date is displayed."
            //Step 25 Click Cancel on the CAA summary on the Caaribou MDS Website.
            //Step 26 "Click the CAA button for 04. Communication. 
                      //Verify the Delirium CAA is displayed."
            //Step 27 "Fill out each tab within the CAA. 
                      //Click the Print button."
            //Step 28 "Select Appropriate printer. 
                      //Select the Print button on the bottom of the Windwos Print Dialog.
                      //Verify the CAA Summary is printed on the selected printer.
                      //Verify the Header, Footer, Resident name, and ARD date is displayed."
            //Step 29 Click Cancel on the CAA summary on the Caribou MDS Website.
        }
    }
}
