using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class CR___Resident_History_Tile___Search_Residents_text_box__last_name_first_name_with_comma_without_comma : BaseSetup
    {
        [Test]
        public void CR_Resident_History_Tile_Search_Residents_text_box_last_name_first_name_with_comma_without_comma()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile.
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Type in the "Search Resident" type in the last name "RAIMDS" from existing resident name
            Driver.InsertText(SearchResidentsPage.residentsSearchTextField, "RAIMDS");
            //Step 3  Verify that residents Last Name matches with search
            VerifyElement.AreEqual(SearchResidentsPage.searchResultLastname, "RAIMDSRESIDENT");
            //Step 4  Clear "Search Resident" field
            //Step 5  Type in the "Search Resident" field one of the existing resident Last name
            Driver.InsertText(SearchResidentsPage.residentsSearchTextField, "RAIMDSRESIDENT");
            //Step 6  Verify that residents Last Name matches with search
            VerifyElement.AreEqual(SearchResidentsPage.searchResultLastname, "RAIMDSRESIDENT");
            //Step 7  Clear "Search Resident" field
            //Step 8  Type in the "Search Resident" field one of the existing resident Last and First name with comma
            Driver.InsertText(SearchResidentsPage.residentsSearchTextField, "RAIMDSRESIDENT, ELEVEN");
            //Step 9  Verify that residents Last Name matches with search
            VerifyElement.AreEqual(SearchResidentsPage.searchResultLastname, "RAIMDSRESIDENT");
            //Step 10 Clear "Search Resident" field
            //Step 11 Type in the "Search Resident" field one of the existing resident Last and First name without comma but with a space
            Driver.InsertText(SearchResidentsPage.residentsSearchTextField, "RAIMDSRESIDENT ELEVEN");
            //Step 12 Verify that residents Last Name matches with search
            VerifyElement.AreEqual(SearchResidentsPage.searchResultLastname, "RAIMDSRESIDENT");
            //Step 13 Clear "Search Resident" field
            //Step 14 Select Enter on the keypad(empty enter)
            Driver.InsertText(SearchResidentsPage.residentsSearchTextField, "");
            Driver.PressEnter(SearchResidentsPage.residentsSearchTextField);
            //Step 15 Type digits
            Driver.InsertText(SearchResidentsPage.residentsSearchTextField, "1234");
            VerifyElement.AreEqual(SearchResidentsPage.noMatchMsg, "There are no residents that match your search.");
            //Step 16 Paste letter
            Driver.InsertText(SearchResidentsPage.residentsSearchTextField, "ABC");
            //Step 17 Paste digits
            Driver.InsertText(SearchResidentsPage.residentsSearchTextField, "1234");
            //Step 18 Paste special characters
            Driver.InsertText(SearchResidentsPage.residentsSearchTextField, "@#@$@");
            VerifyElement.AreEqual(SearchResidentsPage.noMatchMsg, "There are no residents that match your search.");
        }
    }
}
