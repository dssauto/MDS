using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class FacilityDisciplinePage
    {
        #region WebElements

        static internal By pageHeader = By.XPath("//*[@id='mds']/div[1]/div/div/div[1]/h3");
        static internal By disciplineNameLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div/form/div[1]/label");
        static internal By disciplineNameTextField = By.Id("DisciplineName");
        static internal By descriptionLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div/form/div[2]/label");
        static internal By descriptionTextField = By.Id("Description");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/div[1]/div[2]/button[1]");
        static internal By saveButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/div[1]/div[2]/button[2]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.AreEqual(pageHeader, "Facility Discipline");
            VerifyElement.AreEqual(disciplineNameLabel, "Discipline Name");
            VerifyElement.AreEqual(descriptionLabel, "Description");
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(saveButton);

        }

        #endregion

        #region Navigation

        #endregion
    }

}