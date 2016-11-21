using System;
using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class UserPopupWindow
    {
        #region WebElements
        static internal By lockedBtn = By.XPath("//label[@class='btn btn-primary toggle-on'][text()='Locked']");
        static internal By saveBtn = By.XPath("//button[@class='btn btn-primary']");
        static internal By disciplineDropdown = By.Id("Discipline");


        #endregion

        #region Actions
        internal static void SelectDiscipline(string v)
        {
            Driver.SelectDropdown(disciplineDropdown, v);
        }

        internal static void CheckRoles(string v)
        {
            Driver.ClickRadioButton(By.XPath("//button[@aria-label='"+ v +"']"));
        }
        #endregion
    }
}
