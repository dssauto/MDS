using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class CreateNewMDSPage
    {
        #region WebElements
        // Calendar
        static internal By admissionDateCalendarData = By.XPath("//*[@id='selectAdmission']/option");
        static internal By entryDateCalendarTextfield = By.Id("entryDate");
        #endregion

        #region Action
        public static void AddEntryDate()
        {
            string admissionDate = Driver.Instance.FindElement(SchedulePage.admissionDateCalendarData).Text.ToString();
            Driver.InsertText(entryDateCalendarTextfield, admissionDate);
        }
        #endregion
    }
}
