using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EY___CAA_TIU
    {
        [Test]
        public void EY_CAA_TIU()
        {
            Browser.Open();
            LoginPage.SignIn();
            //CPRS Required
//            Step Name   Description
//Step 1  Print the attached document in this step to Verify all 20 CAAs.
//Step 2  Click the Schedule Tile.
//Step 3  Enter the name of the resident to create an admission assessment on in the Search text box.
//Step 4  Select the resident name from the dropdown menu.
//Step 5  On the line item for the Admission assessment click the "Create Assessment" button.
//Step 6  "Select the correct coding for an NC item set.
//The NC item set coding is as follows:
//1.
//99.
//0.
//99."
//Step 7  Click the "Create" button.
//Step 8  Click Section V in the left hand navigation pane.
//Step 9  "Scroll down to V0200 A CAAs and Care Planning. 
//Click the CAA Summary button."
//Step 10 "Enter data into the text box provided.
//Enter E - Sig Code.
//Click the Create TIU Note button."
//Step 11 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 12 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 13 "Click the CAA button for 01. Delirium. 
//Verify the Delirium CAA is displayed."
//Step 14 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 15 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 16 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 17 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 18 "Click the CAA button for 2. Cognitive Loss / Dementia. 
//Verify the Delirium CAA is displayed."
//Step 19 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 20 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 21 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 22 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 23 "Click the CAA button for 03. Visual Function. 
//Verify the Delirium CAA is displayed."
//Step 24 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 25 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 26 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 27 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 28 "Click the CAA button for 04. Communication. 
//Verify the Delirium CAA is displayed."
//Step 29 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 30 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 31 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 32 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 33 "Click the CAA button for 05. Activities of Daily Living (ADLs) - Functional Status / Rehabilitation Potential.
//Verify this CAA has the new 2016 name as stated above.
//Verify the Delirium CAA is displayed."
//Step 34 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 35 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 36 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 37 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 38 "Click the CAA button for 06. Urinary Incontinence and Indwelling Catheter. 
//Verify the Delirium CAA is displayed."
//Step 39 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 40 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 41 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 42 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 43 "Click the CAA button for 07. Psychosocial Well-Being. 
//Verify the Delirium CAA is displayed."
//Step 44 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 45 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 46 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 47 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 48 "Click the CAA button for 08. Mood State. 
//Verify the Delirium CAA is displayed."
//Step 49 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 50 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 51 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 52 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 53 "Click the CAA button for 09. Behavioral Symptoms. 
//Verify the Delirium CAA is displayed."
//Step 54 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 55 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 56 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 57 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 58 "Click the CAA button for 10. Activities. 
//Verify the Delirium CAA is displayed."
//Step 59 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 60 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 61 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 62 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 63 "Click the CAA button for 11. Fall(S). 
//Verify the Delirium CAA is displayed."
//Step 64 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 65 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 66 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 67 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 68 "Click the CAA button for 12. Nutritional Status.
//Verify the Delirium CAA is displayed."
//Step 69 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 70 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 71 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 72 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 73 "Click the CAA button for 13. Feeding Tube(S). 
//Verify the Delirium CAA is displayed."
//Step 74 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 75 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 76 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 77 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 78 "Click the CAA button for 14. Dehydration/Fluid Maintenance. 
//Verify the Delirium CAA is displayed."
//Step 79 "Using the document attached to Step 1 Verify the verbiage of the 14. Dehydration/Fluid Maintenance CAA. 
//Verify that spelling is correct and the correct options are displayed."
//Step 80 Click the Cancel button.
//Step 81 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 82 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 83 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 84 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 85 "Click the CAA button for 15. Dental Care. 
//Verify the Delirium CAA is displayed."
//Step 86 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 87 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 88 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 89 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 90 "Click the CAA button for 16. Pressure Ulcer(S). 
//Verify the Delirium CAA is displayed."
//Step 91 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 92 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 93 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 94 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 95 "Click the CAA button for 17. Psychotropic Medication Use. 
//Verify the Delirium CAA is displayed."
//Step 96 "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 97 "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 98 "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 99 "Close CPRS.
//Re - open the Caribou MDS website."
//Step 100    "Click the CAA button for 18. Physical Restraints. 
//Verify the Delirium CAA is displayed."
//Step 101    "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 102    "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 103    "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 104    "Close CPRS.
//Re - open the Caribou MDS website."
//Step 105    "Click the CAA button for 19. Pain. 
//Verify the Delirium CAA is displayed."
//Step 106    "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 107    "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 108    "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 109    "Close CPRS.
//Re - open the Caribou MDS website."
//Step 110    "Click the CAA button for 20. Return to Community Referral. 
//Verify the Delirium CAA is displayed."
//Step 111    "Fill out each tab within the CAA. 
//Click the TIU tab."
//Step 112    "Enter E-Sig Code.
//Click the Create TIU Note button."
//Step 113    "Open CPRS.
//Enter User Credentials.
//Click the Notes tab on the bottom of CPRS.
//Verify the TIU note just created is displayed.
//Verify the name of the TIU is displayed correctly."
//Step 114    "Close CPRS.
//Re - open the Caribou MDS website."
        }
    }
}
