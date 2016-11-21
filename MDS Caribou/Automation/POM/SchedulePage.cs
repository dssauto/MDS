using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;

namespace Automation.POM
{
    class SchedulePage : BaseSetup
    {
        #region WebElements
        // Page Elements
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");
        static internal By obraFilterButtonChecked = By.XPath("//i[@class='glyphicon glyphicon-ok colorblue ng-scope' and @ng-if='filterButton.obra == true']");
        static internal By obraFilterButtonUnchecked = By.XPath("//*[@id='assessmentTypeButtonGroup']/label[1]");
        static internal By ppsFilterButtonChecked = By.XPath("//i[@class='glyphicon glyphicon-ok colorblue ng-scope' and @ng-if='filterButton.pps == true']");
        static internal By ppsFilterButtonUnchecked = By.XPath("(//div[@id='assessmentTypeButtonGroup']/label)[2]");
        static internal By dueinScroller = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div[1]/div/div[2]/ul/li[2]/div/a");
        static internal By dueinDays = By.XPath("//ul[@class='list-unstyled list-inline']/li[contains(., 'days')]/span");
        static internal By lastNameSearchTextField = By.Id("lastName");
        static internal By selectLocationDropdown = By.Id("selectLocation");
        static internal By selectNeighborhoodLable = By.XPath("(//*[@id='selectLocation']/option)[1]");
        static internal By selectAllNeighborhoodLable = By.XPath("(//*[@id='selectLocation']/option)[last()]");
        static internal By residentColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[1]/span");
        static internal By admitDischargeColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[1]");
        static internal By assessmentColumnTypeLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[2]");
        static internal By ardColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[3]");
        static internal By completeByDateColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[4]");
        static internal By caaCompleteByColumnLabel = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[2]/span[5]");
        static internal By showRemovedButton = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[3]/div/div/label[1]");
        static internal By hideRemovedButton = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[1]/div/div[3]/div/div/label[2]");
        static internal By refreshFilterButton = By.XPath("//button[@class='btn btn-default pull-right']");
        static internal By noAssessmentsMessage = By.XPath("//*[@id='main-content']/div/div[2]/div/ul/li[2]/div/div/label");
        static internal By nameSearchResults = By.XPath("(//ul[@class='dropdown-menu ng-isolate-scope']/li)[1]/a");
        static internal By removeYesButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/button[2]");
        static internal By removeCancelButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/button[1]");
        // Assessment
        static internal By admissionAssessment = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., 'Admission')])[1]");
        static internal By fivedayAssessment = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '5-day')])[1]");
        static internal By fourteendayAssessment = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '14-day')])[1]");
        static internal By thirtydayAssessment = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '30-day')])[1]");
        static internal By sixtydayAssessment = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '60-day')])[1]");
        static internal By ninetydayAssessment = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '90-day')])[1]");
        static internal By quarterlyAssessment = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., 'Quarterly')])[1]");
        static internal By createMDSDropdown = By.XPath("(//button[@class='btn btn-default dropdown-toggle ng-scope'])[1]");
        static internal By createMDSBtn = By.XPath("(//button[@class='btn btn-default'])[1]");
        static internal By removeDropdown = By.XPath("(//ul[@class='dropdown-menu']/li/a)[1]");
        static internal By onePagination = By.LinkText("1");
        static internal By twoPagination = By.LinkText("2");
        static internal By nextPagination = By.LinkText("Next");
        static internal By lastPagination = By.XPath("(//a[@ng-click='selectPage(page.number, $event)'])[last()]");
        static internal By previousPagination = By.LinkText("Previous");
        static internal By numberofAssessments = By.XPath("//*[@id='main-content']/div/div[2]/div[2]/div/div/span");
        static internal By firstResidentfromList = By.XPath("(//li[@class='list-group-item ng-scope'])[1]//following-sibling::h4[@class='clickable ng-binding']");
        static internal By lastResidentfromList = By.XPath("(//h4[@class='clickable ng-binding'])[last()]");
        static internal By residentsDemographicsHeader = By.XPath("//*[@id='mds']/div[1]/div/div/div[1]/h3");
        static internal By residentsDemographicsCloseButton = By.XPath("//button[@class='btn btn-default'][contains(., 'Close')]");
        static internal By residentsDemographicsSYNCButton = By.XPath("//button[@class='btn btn-default pull-left'][contains(., 'Sync')]");
        // Residents Demographics
        static internal By nameLable = By.XPath("//ul[@class='list-unstyled']/li[contains(., 'Name')]");
        static internal By genderLable = By.XPath("//ul[@class='list-unstyled']/li[contains(., 'Gender')]");
        static internal By dateofBirthLable = By.XPath("//ul[@class='list-unstyled']/li[contains(., 'Date Of Birth')]");
        static internal By ssnLable = By.XPath("//ul[@class='list-unstyled']/li[contains(., 'SSN')]");
        static internal By raceLable = By.XPath("//ul[@class='list-unstyled']/li[contains(., 'Race')]");
        static internal By mStatusLable = By.XPath("//ul[@class='list-unstyled']/li[contains(., 'Marital Status')]");
        static internal By statusLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Status')]");
        static internal By admissionDateTimeLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Admission Date Time')]");
        static internal By admissionTypeLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Admission Type')]");
        static internal By admissionDiagnosisLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Admitting Diagnosis')]");
        static internal By attendingPhysicianLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Attending Physician')]");
        static internal By primaryCarePhysicianLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Primary Care Physician')]");
        static internal By roomBedLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Room Bed')]");
        static internal By transferTypeLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Transfer Type')]");
        static internal By treatingSpecialtyLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Treating Specialty')]");
        static internal By neighborhoodLocationLable = By.XPath("//ul[@class='list-unstyled']/li/ul/li[contains(., 'Neighborhood Location')]");
        static internal By initialCircle = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/initials-circle/div/div/span");
        static internal By initialCircleMainpage = By.XPath("//*[@id='main-content']/div/div[2]/div[1]/ul/li[2]/div/div[1]/div/div[1]/initials-circle/div/div");
        static internal By removedFromSkippedButton = By.XPath("//*[@id='main-content']/div/div[2]/div[1]/ul/li[2]/div/div[3]/button");
        static internal By removedSeccess = By.XPath("//*[@id='toast-container']/div/div[2]");
        static internal By historyScheduleDetailsDropdown = By.XPath("(//*[@id='main-content']//i[@class='fa fa-history'])[1]//parent::a");
        //History Schedule Details window elements
        static internal By historyIcon = By.XPath("(//*[@id='mds']//i[@class='fa fa-history'])[1]");
        static internal By calendarIcon = By.XPath("(//*[@id='mds']//i[@class='fa fa-calendar'])[1]");
        static internal By historyScheduleDetailsHeader = By.XPath("//*[@id='mds']//h3[@class='modal-title ng-binding']");
        static internal By iconwithHistory = By.XPath("//*[@id='mds']//div[@class='col-lg-4']/label");
        static internal By assessmentTypeHeader = By.XPath("(//small[text()='Assessment Type'])[1]");
        static internal By A0050Header = By.XPath("//small[text()='A0050']");
        static internal By ardHeader = By.XPath("(//small[text()='ARD'])[1]");
        static internal By completedDateHeader = By.XPath("//small[text()='Completed Date']");
        static internal By rugScoreHeader = By.XPath("//small[text()='Rug Score']");
        static internal By statusHeader = By.XPath("//small[text()='Status']");
        static internal By batchHeader = By.XPath("//small[text()='Batch #']");
        static internal By batchDateHeader = By.XPath("//small[text()='Batch Date']");
        static internal By admissionDate = By.XPath("(//div[@class='col-lg-3'])[3]");
        static internal By admissionDateCalendar = By.Id("selectAdmission");
        static internal By admissionDateCalendarData = By.XPath("//*[@id='selectAdmission']/option");
        static internal By resetScheduleButton = By.XPath("//button[@class='btn btn-default pull-right']");
        static internal By schduleIcon = By.XPath("//label[@class='pull-left']");
        static internal By completeByDateZ0500BHeader = By.XPath("//small[contains(., 'Complete By Date')]");
        static internal By assessmentTypeHeader2 = By.XPath("(//*[@id='mds']//small[text()='Assessment Type'])[2]");
        static internal By ardHeader2 = By.XPath("(//small[text()='ARD'])[2]");
        static internal By cAACompleteByV0200B2Header = By.XPath("//small[contains(., 'CAA Complete By')]");
        static internal By closeScheduleDetails = By.XPath("//*[@id='mds']//a[@class='close pull-right']");
        // Reset OBRA Schedule 
        static internal By resetIcon = By.XPath("//h3[@class='modal-title']/i");
        static internal By resetOBRAScheduleHeader = By.XPath("//h3[@class='modal-title']");
        static internal By resetOBRAScheduleNote = By.XPath("//div[@class='col-lg-11 col-lg-offset-1']/p");
        static internal By resetScheduleCancelBtn = By.XPath("(//div[@class='modal-footer ng-scope']/button)[1]");
        static internal By resetScheduleResetBtn = By.XPath("(//div[@class='modal-footer ng-scope']/button)[2]");
        static internal By dateRadioBtn = By.XPath("//div[@class='iradio_square-blue']");
        static internal By resetSuccessNotification = By.XPath("//*[@id='toast-container']/div/div[1]");
        // VistA Login
        static internal By vistALoginTitle = By.XPath("//span[@class='glyphicon glyphicon-log-in']");
        static internal By accessCode = By.Id("userAccessCode");
        static internal By verifyCode = By.Id("userVerifyCode");
        static internal By loginBtn = By.XPath("(//button[@class='btn btn-success pull-right'])[1]");
        static internal By cancelBtn = By.XPath("(//button[@class='btn btn-default pull-right'])[1]");
        static internal By vistALoginSuccess = By.XPath("//*[@id='toast-container']/div/div[2]");
        // Create New MDS window
        static internal By createNewMDSHeader = By.XPath("//*[@id='mds']/div[1]/div/div/div[1]/h3");
        static internal By CreateNewMDSCancelBtn = By.XPath("//button[@class='btn btn-default']/i[@class='fa fa-close']");
        static internal By calendarARD = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div/form/div/div[2]/div[2]/div/p/span/button");
        static internal By calendarARDTextfield = By.Id("ard");
        static internal By entryDateCalendarTextfield = By.Id("entryDate");
        static internal By calendarARDTodayBtn = By.XPath("//button[@class='btn btn-sm btn-info uib-datepicker-current ng-binding'][text()='Today']");
        static internal By calendarARDClearBtn = By.XPath("//button[@class='btn btn-sm btn-danger uib-clear ng-binding'][text()='Clear']");
        static internal By calendarARDDoneBtn = By.XPath("//button[@class='btn btn-sm btn-success pull-right uib-close ng-binding'][text()='Done']");
        static internal By carePlanReviewDateCalendar = By.XPath("(//button[@class='btn btn-default']/i[@class='glyphicon glyphicon-calendar'])[2]");
        static internal By a1600EntryDateCalendar = By.XPath("(//button[@class='btn btn-default']/i[@class='glyphicon glyphicon-calendar'])[3]");
        static internal By calendarTodayBtn = By.XPath("//button[@class='btn btn-sm btn-info uib-datepicker-current ng-binding'][text()='Today']");
        static internal By calendarClearBtn = By.XPath("//button[@class='btn btn-sm btn-danger uib-clear ng-binding'][text()='Clear']");
        static internal By calendarDoneBtn = By.XPath("//button[@class='btn btn-sm btn-success pull-right uib-close ng-binding'][text()='Done']");


        // Create MDS radio buttons
        static internal By a01RadioBtn = By.XPath("(//span[contains(., '01')]//preceding-sibling::div)[1]");
        static internal By a02RadioBtn = By.XPath("//div[@class='radio'][contains(., '02')]/label/div");
        static internal By a03RadioBtn = By.XPath("//div[@class='radio'][contains(., '03')]/label/div");
        static internal By a04RadioBtn = By.XPath("(//div[@class='radio unwrap'][contains(., '04')]/label/div)[1]");
        static internal By a05RadioBtn = By.XPath("(//div[@class='radio unwrap'][contains(., '05')]/label/div)[1]");
        static internal By a06RadioBtn = By.XPath("(//div[@class='radio unwrap'][contains(., '06')]/label/div)[1]");
        static internal By a99RadioBtn = By.XPath("(//label[contains(., '99')])[1]");
        static internal By b01RadioBtn = By.XPath("(//span[contains(., '01')]//preceding-sibling::div)[2]");
        static internal By b02RadioBtn = By.XPath("//div[@class='radio unwrap'][contains(., '02')]/label/div");
        static internal By b03RadioBtn = By.XPath("//div[@class='radio unwrap'][contains(., '03')]/label/div");
        static internal By b04RadioBtn = By.XPath("(//div[@class='radio unwrap'][contains(., '04')]/label/div)[2]");
        static internal By b05RadioBtn = By.XPath("(//div[@class='radio unwrap'][contains(., '05')]/label/div)[2]");
        static internal By b07RadioBtn = By.XPath("//div[@class='radio unwrap'][contains(., '07')]/label/div");
        static internal By b99RadioBtn = By.XPath("(//div[@class='radio'][contains(., '99')]/label/div)[2]");

        static internal By c0RadioBtn = By.XPath("(//div[@class='radio'][contains(., '0')]/label/div)[3]");
        static internal By c1RadioBtn = By.XPath("//div[@class='radio'][contains(., '1')]/label/div");
        static internal By c2RadioBtn = By.XPath("(//div[@class='radio'][contains(., '2')]/label/div)[2]");
        static internal By c3RadioBtn = By.XPath("(//div[@class='radio'][contains(., '3')]/label/div)[2]");
        static internal By c4RadioBtn = By.XPath("//div[@class='radio'][contains(., '4')]/label/div");

        static internal By f01RadioBtn = By.XPath("(//div[@class='radio unwrap'][contains(., '01')]/label/div)[3]");
        static internal By f10RadioBtn = By.XPath("//div[@class='radio unwrap'][contains(., '10')]/label/div");
        static internal By f11RadioBtn = By.XPath("//div[@class='radio unwrap'][contains(., '11')]/label/div");
        static internal By f12RadioBtn = By.XPath("//div[@class='radio unwrap'][contains(., '12')]/label/div");
        static internal By f99RadioBtn = By.XPath("//div[@class='radio unwrap'][contains(., '99')]/label/div");
        static internal By f0NoRadioBtn = By.XPath("(//div[@class='radio unwrap'][contains(., 'No')]/label/div)[2]");
        static internal By f1YesRadioBtn = By.XPath("//div[@class='radio unwrap'][contains(., 'Yes')]/label/div");
        static internal By ardTextfield = By.Id("ard");
        static internal By createNewMDSCreateBtnEnabled = By.XPath("//button[@class='btn btn-primary' and @aria-disabled='false']");
        static internal By createNewMDSCreateBtnDisabled = By.XPath("//button[@class='btn btn-primary' and @aria-disabled='true']");
        static internal By assessmentHeader = By.XPath("//span[@class='panel-title']");

        #endregion

        #region Action
        internal static void CreateMDSBy(string v)
        {
            Driver.ClickOn(By.XPath("(//span[contains(.,'" + v + "')]//parent::div//parent::div//button[contains(.,'Create MDS')])[1]"));
        }
        internal static void CreateNewMDS(string days)
        {
            Driver.ClickOn(calendarARD);
            Driver.ClickOn(calendarTodayBtn);
            Driver.ClickOn(carePlanReviewDateCalendar);
            Driver.ClickOn(calendarTodayBtn);
            Driver.ClickOn(a1600EntryDateCalendar);
            Driver.ClickOn(calendarTodayBtn);
            Driver.ClickRadioButton(By.XPath("(//span[contains(., '" + days + "')]//preceding-sibling::div)[1]"));
            Driver.ClickOn(createNewMDSCreateBtnEnabled);
        }
        internal static void VerifyCompleteByDate(string aType)
        {
            int count = 0;
            while (true)
            {
                // Check to see if limit it hit.
                if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + aType + "')])[1]")))
                {
                    break;
                }
                // This will check if there is next pagination available
                if (Driver.IsElementPresent(By.XPath("//li[@class='pagination-next ng-scope']/a")))
                {
                    Driver.ClickOn(nextPagination);
                    Driver.WaitFor(2);
                }
                else
                {
                    count++;
                    if (count > 1) { break; }
                    Driver.ClickOn(onePagination);
                    Driver.WaitFor(2);
                }
            }
            try
            {
                // Grab ARD date
                Driver.WaitFor(2);
                string ardDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + aType + "')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                string ardMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + aType + "')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                string ardYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + aType + "')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                // Convert ARD days to date and time
                DateTime ardDate = new DateTime(Convert.ToInt32(ardYear), ConvertMonthString(ardMonth), Convert.ToInt32(ardDay));
                // Switch to assessment type and add days
                switch (aType)
                {
                    case "Admission":
                        ardDate = ardDate.AddDays(0);
                        break;
                    case "Quarterly":
                        ardDate = ardDate.AddDays(14);
                        break;
                    case "Annual":
                        ardDate = ardDate.AddDays(14);
                        break;
                    case "5-day":
                        ardDate = ardDate.AddDays(1);
                        break;
                    case "14-day":
                        ardDate = ardDate.AddDays(1);
                        break;
                    case "30-day":
                        ardDate = ardDate.AddDays(1);
                        break;
                    case "60-day":
                        ardDate = ardDate.AddDays(1);
                        break;
                    case "90-day":
                        ardDate = ardDate.AddDays(1);
                        break;
                }
                // Grab Complete By date 
                string completeByDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + aType + "')]//label[@class='date ng-binding'])[2]")).Text.ToString();
                // Convert the days
                string cDay = completeByDay.Substring(3, 2);
                string cMonth = completeByDay.Substring(0, 3);
                string cYear = completeByDay.Substring(7, 4);
                DateTime completeDate = new DateTime(Convert.ToInt32(cYear), ConvertMonthString(cMonth), Convert.ToInt32(cDay));
                // Compare
                try
                {
                    Assert.AreEqual(ardDate, completeDate);
                    TestReport.Log(LogStatus.Pass, "Complete By Date is verified");
                }
                catch (Exception e)
                {
                    VerifyElement.ExceptionLog(e.Message);
                }
            }
            catch (AssertionException e)
            {
                string screenName = ScreenshotHelper.TakeScreenshot();
                string scrrenShotPath = TestReport.AddScreenCapture(screenName);
                TestReport.Log(LogStatus.Warning, e.Message, scrrenShotPath);
            }
        }
        internal static void VerifyAdmissionToQ1Days(string resident)
        {
            Driver.WaitFor(2);
            if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//h4[@class='clickable ng-binding'])[1]")))
            {
                // ARD Admission date
                string admissionDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                string admissionMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                string admissionYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                DateTime admissionDate = new DateTime(Convert.ToInt32(admissionYear), ConvertMonthString(admissionMonth), Convert.ToInt32(admissionDay));

                if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[1]")))
                {
                    // ARD Q1 date
                    string quarterlyDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string quarterlyMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string quarterlyYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime quarterlyDate = new DateTime(Convert.ToInt32(quarterlyYear), ConvertMonthString(quarterlyMonth), Convert.ToInt32(quarterlyDay));
                    TimeSpan timespan = quarterlyDate.Subtract(admissionDate);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Admission - " + admissionDate.ToShortDateString() + " and Q1 - " + quarterlyDate.ToShortDateString() + "");
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    Driver.WaitFor(3);
                    string quarterlyDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string quarterlyMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string quarterlyYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime quarterlyDate = new DateTime(Convert.ToInt32(quarterlyYear), ConvertMonthString(quarterlyMonth), Convert.ToInt32(quarterlyDay));
                    TimeSpan timespan = quarterlyDate.Subtract(admissionDate);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Admission - " + admissionDate.ToShortDateString() + " and Q1 - " + quarterlyDate.ToShortDateString() + "");
                }
            }
            else
            {
                Driver.ClickOn(nextPagination);
                Driver.WaitFor(1);
                // ARD Admission date
                string admissionDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                string admissionMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                string admissionYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                DateTime admissionDate = new DateTime(Convert.ToInt32(admissionYear), ConvertMonthString(admissionMonth), Convert.ToInt32(admissionDay));

                if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[1]")))
                {
                    // ARD Q1 date
                    string quarterlyDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string quarterlyMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string quarterlyYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime quarterlyDate = new DateTime(Convert.ToInt32(quarterlyYear), ConvertMonthString(quarterlyMonth), Convert.ToInt32(quarterlyDay));
                    TimeSpan timespan = quarterlyDate.Subtract(admissionDate);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Admission - " + admissionDate.ToShortDateString() + " and Q1 - " + quarterlyDate.ToShortDateString() + "");
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    Driver.WaitFor(1);
                    string quarterlyDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string quarterlyMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string quarterlyYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime quarterlyDate = new DateTime(Convert.ToInt32(quarterlyYear), ConvertMonthString(quarterlyMonth), Convert.ToInt32(quarterlyDay));
                    TimeSpan timespan = quarterlyDate.Subtract(admissionDate);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Admission - " + admissionDate.ToShortDateString() + " and Q1 - " + quarterlyDate.ToShortDateString() + "");
                }
            }
        }
        internal static void VerifyAdmissionToQ1DaysWithManualDays(string resident, int days)
        {
            Driver.WaitFor(2);
            if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//h4[@class='clickable ng-binding'])[1]")))
            {
                // ARD Admission date
                string admissionDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                string admissionMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                string admissionYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                DateTime admissionDate = new DateTime(Convert.ToInt32(admissionYear), ConvertMonthString(admissionMonth), Convert.ToInt32(admissionDay));

                if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[1]")))
                {
                    // ARD Q1 date
                    string quarterlyDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string quarterlyMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string quarterlyYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime quarterlyDate = new DateTime(Convert.ToInt32(quarterlyYear), ConvertMonthString(quarterlyMonth), Convert.ToInt32(quarterlyDay));
                    TimeSpan timespan = quarterlyDate.Subtract(admissionDate);
                    Assert.AreEqual(timespan.TotalDays, days + .0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Admission - " + admissionDate.ToShortDateString() + " and Q1 - " + quarterlyDate.ToShortDateString() + "");
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    Driver.WaitFor(3);
                    string quarterlyDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string quarterlyMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string quarterlyYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime quarterlyDate = new DateTime(Convert.ToInt32(quarterlyYear), ConvertMonthString(quarterlyMonth), Convert.ToInt32(quarterlyDay));
                    TimeSpan timespan = quarterlyDate.Subtract(admissionDate);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Admission - " + admissionDate.ToShortDateString() + " and Q1 - " + quarterlyDate.ToShortDateString() + "");
                }
            }
            else
            {
                Driver.ClickOn(nextPagination);
                Driver.WaitFor(1);
                // ARD Admission date
                string admissionDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                string admissionMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                string admissionYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Admission')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                DateTime admissionDate = new DateTime(Convert.ToInt32(admissionYear), ConvertMonthString(admissionMonth), Convert.ToInt32(admissionDay));

                if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[1]")))
                {
                    // ARD Q1 date
                    string quarterlyDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string quarterlyMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string quarterlyYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime quarterlyDate = new DateTime(Convert.ToInt32(quarterlyYear), ConvertMonthString(quarterlyMonth), Convert.ToInt32(quarterlyDay));
                    TimeSpan timespan = quarterlyDate.Subtract(admissionDate);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Admission - " + admissionDate.ToShortDateString() + " and Q1 - " + quarterlyDate.ToShortDateString() + "");
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    Driver.WaitFor(1);
                    string quarterlyDay = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string quarterlyMonth = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string quarterlyYear = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime quarterlyDate = new DateTime(Convert.ToInt32(quarterlyYear), ConvertMonthString(quarterlyMonth), Convert.ToInt32(quarterlyDay));
                    TimeSpan timespan = quarterlyDate.Subtract(admissionDate);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Admission - " + admissionDate.ToShortDateString() + " and Q1 - " + quarterlyDate.ToShortDateString() + "");
                }
            }
        }
        internal static void VerifyQ1ToQ2Days(string resident)
        {
            Driver.WaitFor(2);
            if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[1]")))
            {
                // ARD Q1 date
                string q1Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                string q1Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                string q1Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                DateTime q1Date = new DateTime(Convert.ToInt32(q1Year), ConvertMonthString(q1Month), Convert.ToInt32(q1Day));

                if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[2]")))
                {
                    // ARD Q2 date
                    string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[2]")).Text.ToString();
                    string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[2]")).Text.ToString();
                    string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[2]")).Text.ToString();
                    DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                    TimeSpan timespan = q2Date.Subtract(q1Date);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q1 - " + q1Date.ToShortDateString() + " and Q2 - " + q2Date.ToShortDateString() + "");
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    Driver.WaitFor(3);
                    // ARD Q2 date
                    string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                    TimeSpan timespan = q2Date.Subtract(q1Date);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q1 - " + q1Date.ToShortDateString() + " and Q2 - " + q2Date.ToShortDateString() + "");
                }
            }
            else
            {
                Driver.ClickOn(nextPagination);
                Driver.WaitFor(1);
                // ARD Q1 date
                string q1Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                string q1Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                string q1Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                DateTime q1Date = new DateTime(Convert.ToInt32(q1Year), ConvertMonthString(q1Month), Convert.ToInt32(q1Day));

                if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[2]")))
                {
                    // ARD Q2 date
                    string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[2]")).Text.ToString();
                    string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[2]")).Text.ToString();
                    string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[2]")).Text.ToString();
                    DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                    TimeSpan timespan = q2Date.Subtract(q1Date);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q1 - " + q1Date.ToShortDateString() + " and Q2 - " + q2Date.ToShortDateString() + "");
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    Driver.WaitFor(3);
                    // ARD Q2 date
                    string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                    TimeSpan timespan = q2Date.Subtract(q1Date);
                    Assert.AreEqual(timespan.TotalDays, 90.0d);
                    TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q1 - " + q1Date.ToShortDateString() + " and Q2 - " + q2Date.ToShortDateString() + "");
                }
            }
        }
        internal static void VerifyQ2ToQ3Days(string resident)
        {
            Driver.ClickOn(SchedulePage.onePagination);
            Driver.WaitFor(3);
            if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[1]")))
            {
                if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[2]")))
                {
                    string q1Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[2]")).Text.ToString();
                    string q1Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[2]")).Text.ToString();
                    string q1Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[2]")).Text.ToString();
                    DateTime q1Date = new DateTime(Convert.ToInt32(q1Year), ConvertMonthString(q1Month), Convert.ToInt32(q1Day));

                    if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[3]")))
                    {
                        string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[3]")).Text.ToString();
                        string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[3]")).Text.ToString();
                        string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[3]")).Text.ToString();
                        DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                        TimeSpan timespan = q2Date.Subtract(q1Date);
                        Assert.AreEqual(timespan.TotalDays, 90.0d);
                        TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q2 - " + q1Date.ToShortDateString() + " and Q3 - " + q2Date.ToShortDateString() + "");
                    }
                    else
                    {
                        Driver.ClickOn(nextPagination);
                        Driver.WaitFor(3);
                        string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[3]")).Text.ToString();
                        string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[3]")).Text.ToString();
                        string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[3]")).Text.ToString();
                        DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                        TimeSpan timespan = q2Date.Subtract(q1Date);
                        Assert.AreEqual(timespan.TotalDays, 90.0d);
                        TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q2 - " + q1Date.ToShortDateString() + " and Q3 - " + q2Date.ToShortDateString() + "");
                    }
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    Driver.WaitFor(3);
                    string q1Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                    string q1Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                    string q1Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                    DateTime q1Date = new DateTime(Convert.ToInt32(q1Year), ConvertMonthString(q1Month), Convert.ToInt32(q1Day));

                    if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[2]")))
                    {
                        string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[2]")).Text.ToString();
                        string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[2]")).Text.ToString();
                        string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[2]")).Text.ToString();
                        DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                        TimeSpan timespan = q2Date.Subtract(q1Date);
                        Assert.AreEqual(timespan.TotalDays, 90.0d);
                        TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q2 - " + q1Date.ToShortDateString() + " and Q3 - " + q2Date.ToShortDateString() + "");
                    }
                    else
                    {
                        Driver.ClickOn(nextPagination);
                        Driver.WaitFor(3);
                        string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[3]")).Text.ToString();
                        string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[3]")).Text.ToString();
                        string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[3]")).Text.ToString();
                        DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                        TimeSpan timespan = q2Date.Subtract(q1Date);
                        Assert.AreEqual(timespan.TotalDays, 90.0d);
                        TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q2 - " + q1Date.ToShortDateString() + " and Q3 - " + q2Date.ToShortDateString() + "");
                    }

                }

            }
            else
            {
                Driver.ClickOn(nextPagination);
                if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[1]")))
                {
                    if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[2]")))
                    {
                        string q1Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[2]")).Text.ToString();
                        string q1Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[2]")).Text.ToString();
                        string q1Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[2]")).Text.ToString();
                        DateTime q1Date = new DateTime(Convert.ToInt32(q1Year), ConvertMonthString(q1Month), Convert.ToInt32(q1Day));
                        if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[3]")))
                        {
                            string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[3]")).Text.ToString();
                            string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[3]")).Text.ToString();
                            string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[3]")).Text.ToString();
                            DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                            TimeSpan timespan = q2Date.Subtract(q1Date);
                            Assert.AreEqual(timespan.TotalDays, 90.0d);
                            TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q2 - " + q1Date.ToShortDateString() + " and Q3 - " + q2Date.ToShortDateString() + "");
                        }
                        else
                        {
                            Driver.ClickOn(nextPagination);
                            Driver.WaitFor(3);
                            string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[2]")).Text.ToString();
                            string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[2]")).Text.ToString();
                            string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[2]")).Text.ToString();
                            DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                            TimeSpan timespan = q2Date.Subtract(q1Date);
                            Assert.AreEqual(timespan.TotalDays, 90.0d);
                            TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q2 - " + q1Date.ToShortDateString() + " and Q3 - " + q2Date.ToShortDateString() + "");
                        }

                    }
                    else
                    {
                        Driver.ClickOn(nextPagination);
                        if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[1]")))
                        {
                            string q1Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                            string q1Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                            string q1Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                            DateTime q1Date = new DateTime(Convert.ToInt32(q1Year), ConvertMonthString(q1Month), Convert.ToInt32(q1Day));
                            if (Driver.IsElementPresent(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//h4[@class='clickable ng-binding'])[2]")))
                            {
                                string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[2]")).Text.ToString();
                                string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[2]")).Text.ToString();
                                string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[2]")).Text.ToString();
                                DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                                TimeSpan timespan = q2Date.Subtract(q1Date);
                                Assert.AreEqual(timespan.TotalDays, 90.0d);
                                TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q2 - " + q1Date.ToShortDateString() + " and Q3 - " + q2Date.ToShortDateString() + "");
                            }
                            else
                            {
                                Driver.ClickOn(nextPagination);
                                Driver.WaitFor(3);
                                string q2Day = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                                string q2Month = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='month ng-binding'])[1]")).Text.ToString();
                                string q2Year = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'][contains(., '" + resident + "')][contains(., 'Quarterly')]//span[@class='year ng-binding'])[1]")).Text.ToString();
                                DateTime q2Date = new DateTime(Convert.ToInt32(q2Year), ConvertMonthString(q2Month), Convert.ToInt32(q2Day));
                                TimeSpan timespan = q2Date.Subtract(q1Date);
                                Assert.AreEqual(timespan.TotalDays, 90.0d);
                                TestReport.Log(LogStatus.Pass, "There are " + timespan.TotalDays + " days between Q2 - " + q1Date.ToShortDateString() + " and Q3 - " + q2Date.ToShortDateString() + "");
                            }
                        }
                    }
                }
            }
        }
        internal static int ConvertMonthString(string v)
        {
            int vMonth = 0;
            switch (v)
            {
                case "Jan":
                    vMonth = 1;
                    break;
                case "Feb":
                    vMonth = 2;
                    break;
                case "Mar":
                    vMonth = 3;
                    break;
                case "Apr":
                    vMonth = 4;
                    break;
                case "May":
                    vMonth = 5;
                    break;
                case "Jun":
                    vMonth = 6;
                    break;
                case "Jul":
                    vMonth = 7;
                    break;
                case "Aug":
                    vMonth = 8;
                    break;
                case "Sep":
                    vMonth = 9;
                    break;
                case "Oct":
                    vMonth = 10;
                    break;
                case "Nov":
                    vMonth = 11;
                    break;
                case "Dec":
                    vMonth = 12;
                    break;
            }
            return vMonth;
        }
        internal static void VerifyPPSResident(string aDay)
        {
            if (Driver.IsElementPresent(By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//h4[@class='clickable ng-binding'])[1]")))
            {
                Driver.WaitFor(1);
                By _resident = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//h4[@class='clickable ng-binding'])[1]");
                By _admitDischarge = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//label[@class='date ng-binding'])[1]");
                By _assessmentType = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//span[@class='label ng-binding ng-scope'])[1]");
                Driver.WaitForElement(_assessmentType);
                string _ardDate = Driver.Instance.FindElement(By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                string _completeByDate = Driver.Instance.FindElement(By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//label[@class='date ng-binding'])[2]")).Text.ToString();
                string _cByDate = _completeByDate.Substring(4, 2);
                string _ardDateSum = (Convert.ToInt32(_ardDate) + 1).ToString();
                VerifyElement.IsPresent(_resident);
                VerifyElement.IsPresent(_admitDischarge);
                VerifyElement.AreEqual(_assessmentType, aDay);
                try
                {
                    Assert.AreEqual(_ardDateSum, _cByDate);
                }
                catch (Exception e)
                {

                    VerifyElement.ExceptionLog(e.Message);
                }
            }
            else
            {
                Driver.ClickOn(nextPagination);
                Driver.WaitFor(1);
                By _resident = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//h4[@class='clickable ng-binding'])[1]");
                By _admitDischarge = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//label[@class='date ng-binding'])[1]");
                By _assessmentType = By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//span[@class='label ng-binding ng-scope'])[1]");
                Driver.WaitForElement(_assessmentType);
                string _ardDate = Driver.Instance.FindElement(By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//span[@class='day ng-binding'])[1]")).Text.ToString();
                string _completeByDate = Driver.Instance.FindElement(By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '" + aDay + "')]//label[@class='date ng-binding'])[2]")).Text.ToString();
                string _cByDate = _completeByDate.Substring(4, 2);
                string _ardDateSum = (Convert.ToInt32(_ardDate) + 1).ToString();
                VerifyElement.IsPresent(_resident);
                VerifyElement.IsPresent(_admitDischarge);
                VerifyElement.AreEqual(_assessmentType, aDay);
                try
                {
                    Assert.AreEqual(_ardDateSum, _cByDate);
                }
                catch (Exception e)
                {

                    VerifyElement.ExceptionLog(e.Message);
                }
            }
        }
        internal static void Compare14DayARDdate()
        {
            string admissionDate = Driver.Instance.FindElement(By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '14-day')]//label[@class='date ng-binding'])[1]")).Text.ToString();
            string ardDate = Driver.Instance.FindElement(By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '14-day')]//span[@class='day ng-binding'])[1]")).Text.ToString();
            string completeByDate = Driver.Instance.FindElement(By.XPath("(//ul[@class='list-group']/li[@class='list-group-item ng-scope'][contains(., '14-day')]//label[@class='date ng-binding'])[2]")).Text.ToString();
            // Grab Admission Date
            string aDate = admissionDate.Substring(6, 2);
            string dateSum = (Convert.ToInt32(aDate) + 13).ToString();
            string cByDate = completeByDate.Substring(8, 2);
            string cByDateSum = (Convert.ToInt32(aDate) + 14).ToString();
            string ardSum = (Convert.ToInt32(ardDate) + 1).ToString();
            // VERIFY THAT THE ARD IS DAY 14(ADMISSION DATE = DAY 1)
            try
            {
                Assert.AreEqual(dateSum, ardDate);
            }
            catch (Exception e)
            {

                VerifyElement.ExceptionLog(e.Message);
            }

            // VERIFY THE COMPLETE BY DATE = DAY 14(ADMISSION DATE = DAY 1)
            try
            {
                Assert.AreEqual(ardSum, cByDateSum);
            }
            catch (Exception e)
            {

                VerifyElement.ExceptionLog(e.Message);
            }
        }
        internal static void CreateMDSassessment()
        {
            Driver.ClickOn(calendarARD);
            Driver.ClickOn(calendarARDTodayBtn);
            Driver.ClickOn(carePlanReviewDateCalendar);
            Driver.ClickOn(calendarTodayBtn);
            Driver.ClickOn(a1600EntryDateCalendar);
            Driver.ClickOn(calendarTodayBtn);
            Driver.ClickOn(createNewMDSCreateBtnEnabled);
            VerifyElement.AreEqual(assessmentHeader, "Assessment Header");

        }
        internal static void VerifyCreateMDSRadioBtnClickable()
        {
            Driver.ClickOn(a01RadioBtn);
            Driver.ClickOn(a02RadioBtn);
            Driver.ClickOn(a03RadioBtn);
            Driver.ClickOn(a04RadioBtn);
            Driver.ClickOn(a05RadioBtn);
            Driver.ClickOn(a06RadioBtn);
            Driver.ClickOn(a99RadioBtn);

            Driver.ClickOn(b01RadioBtn);
            Driver.ClickOn(b02RadioBtn);
            Driver.ClickOn(b03RadioBtn);
            Driver.ClickOn(b04RadioBtn);
            Driver.ClickOn(b05RadioBtn);
            Driver.ClickOn(b07RadioBtn);
            Driver.ClickOn(b99RadioBtn);

            Driver.ClickOn(c0RadioBtn);
            Driver.ClickOn(c1RadioBtn);
            Driver.ClickOn(c2RadioBtn);
            Driver.ClickOn(c3RadioBtn);
            Driver.ClickOn(c4RadioBtn);

            Driver.ClickOn(f01RadioBtn);
            Driver.ClickOn(f10RadioBtn);
            Driver.ClickOn(f11RadioBtn);
            Driver.ClickOn(f12RadioBtn);
            Driver.ClickOn(f99RadioBtn);

            Driver.ClickOn(calendarARD);
            Driver.ClickOn(calendarARDTodayBtn);
            Driver.ClickOn(f0NoRadioBtn);
            Driver.ClickOn(f1YesRadioBtn);
        }
        internal static void CreateNewMDSPageElementVerification()
        {
            try
            {
                Assert.AreEqual("Create New MDS", Driver.Instance.FindElement(By.XPath("//h3")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Admission Date", Driver.Instance.FindElement(By.CssSelector("label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.Id("selectAdmission")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("A2300. Assessment Reference Date (ARD):", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div/div[2]/div[2]/div/label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.Id("ard")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Care Plan Review Date:", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div/div[2]/div[3]/div/label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.Id("carePlan")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("A1600. Entry Date:", Driver.Instance.FindElement(By.XPath("//body[@id='mds']/div/div/div/div[2]/div/div/form/div/div[2]/div[4]/div/label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.Id("entryDate")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("A0310. Type of Assessment", Driver.Instance.FindElement(By.CssSelector("h4")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("A. Federal OBRA Reason for Assessment", Driver.Instance.FindElement(By.Id("obra_label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("01. Admission assessment (required by day 14)", Driver.Instance.FindElement(By.XPath("//label/span")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("02. Quarterly review assessment", Driver.Instance.FindElement(By.XPath("//div[2]/label")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("03. Annual assessment", Driver.Instance.FindElement(By.XPath("//div[3]/label")).Text);
            }
            catch (Exception e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Significant change in status", Driver.Instance.FindElement(By.XPath("//div[4]/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("Significant correction", Driver.Instance.FindElement(By.XPath("//div[5]/label/span/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("None of the above", Driver.Instance.FindElement(By.XPath("//div[7]/label/strong")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual("PPS Scheduled Assessments for a Medicare Part A Stay", Driver.Instance.FindElement(By.XPath("//u")).Text);
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.XPath("//body[@id='mds']/div/div/div/div[3]/div/div/div/label")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.XPath("//body[@id='mds']/div/div/div/div[3]/div/div/div/label[2]")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.IsTrue(Driver.IsElementPresent(By.CssSelector("div.col-lg-5 > button.btn.btn-default")));
            }
            catch (AssertionException e)
            {
                VerifyElement.ExceptionLog(e.Message);
            }
        }
        internal static void VistALogin()
        {
            Driver.InsertText(accessCode, "rairac123.");
            Driver.InsertText(verifyCode, "rairac123!");
            Driver.ClickOn(loginBtn);
            VerifyElement.AreEqual(vistALoginSuccess, "Successful Authentication");
        }
        internal static void VistALoginManual(string aCode, string vCode)
        {
            Driver.InsertText(accessCode, aCode);
            Driver.InsertText(verifyCode, vCode);
            Driver.ClickOn(loginBtn);
        }
        internal static void VerifyVistALoginElements()
        {
            VerifyElement.IsPresent(vistALoginTitle);
            VerifyElement.IsPresent(accessCode);
            VerifyElement.IsPresent(verifyCode);
            VerifyElement.IsPresent(loginBtn);
            VerifyElement.IsPresent(cancelBtn);
        }
        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite Schedule");
            VerifyElement.AreEqual(pageHeader, "Schedule");
            VerifyElement.IsPresent(UserMenu.notificationsIcon);
            VerifyElement.IsPresent(UserMenu.userIcon);
            VerifyElement.IsPresent(obraFilterButtonChecked);
            VerifyElement.IsPresent(ppsFilterButtonChecked);
            VerifyElement.IsPresent(dueinScroller);
            VerifyElement.IsPresent(lastNameSearchTextField);
            VerifyElement.IsPresent(selectLocationDropdown);
            VerifyElement.AreEqual(residentColumnLabel, "Resident");
            VerifyElement.AreEqual(admitDischargeColumnLabel, "Admit\r\nDischarge");
            VerifyElement.AreEqual(assessmentColumnTypeLabel, "Assessment Type");
            VerifyElement.AreEqual(ardColumnLabel, "ARD");
            VerifyElement.AreEqual(completeByDateColumnLabel, "Complete By Date (Z0500B)");
            VerifyElement.AreEqual(caaCompleteByColumnLabel, "CAA Complete By (V0200B2)");
            VerifyElement.AreEqual(showRemovedButton, "SHOW REMOVED");
            VerifyElement.AreEqual(hideRemovedButton, "HIDE REMOVED");
            VerifyElement.IsPresent(refreshFilterButton);
            //Residents Tiles 
            VerifyElement.IsPresent(createMDSDropdown);
            VerifyElement.IsPresent(onePagination);
            VerifyElement.IsPresent(numberofAssessments);
        }
        internal static void SelectResident(string residentName)
        {
            Driver.InsertText(lastNameSearchTextField, residentName);
            Driver.PressEnter(lastNameSearchTextField);
        }
        internal static void MoveSlider(int x)
        {
            Driver.WaitForElement(dueinScroller);
            IWebElement slider = Driver.Instance.FindElement(dueinScroller);
            Actions ac = new Actions(Driver.Instance);
            ac.DragAndDropToOffset(slider, x, 0);
            ac.Build().Perform();
            Driver.WaitForPageLoad();
        }
        internal static void SelectNeighborhood(string v)
        {
            Driver.SelectDropdown(selectLocationDropdown, v);
        }
        internal static void VerifyResidentsDemographicsPageElements()
        {
            VerifyElement.AreEqual(residentsDemographicsHeader, "Resident's Demographics");
            VerifyElement.IsPresent(nameLable);
            VerifyElement.IsPresent(genderLable);
            VerifyElement.IsPresent(dateofBirthLable);
            VerifyElement.IsPresent(ssnLable);
            VerifyElement.IsPresent(raceLable);
            VerifyElement.IsPresent(mStatusLable);
            VerifyElement.IsPresent(statusLable);
            VerifyElement.IsPresent(admissionDateTimeLable);
            VerifyElement.IsPresent(admissionTypeLable);
            VerifyElement.IsPresent(admissionDiagnosisLable);
            VerifyElement.IsPresent(attendingPhysicianLable);
            VerifyElement.IsPresent(primaryCarePhysicianLable);
            VerifyElement.IsPresent(roomBedLable);
            VerifyElement.IsPresent(transferTypeLable);
            VerifyElement.IsPresent(treatingSpecialtyLable);
            VerifyElement.IsPresent(neighborhoodLocationLable);
            VerifyElement.IsPresent(residentsDemographicsCloseButton);
            VerifyElement.IsPresent(residentsDemographicsSYNCButton);
        }
        internal static void VerifyInitialsMatchsName()
        {
            var name = Driver.Instance.FindElement(initialCircleMainpage).Text.Trim();
            VerifyElement.AreEqual(initialCircle, name);
        }
        internal static void VerifyARDdateSorted()
        {
            string m1 = Driver.Instance.FindElement(By.XPath("//*[@id='main-content']/div/div[2]/div[1]/ul/li[3]/div/div[2]/div[3]/div[1]/span[1]")).Text.ToString();
            string m2 = Driver.Instance.FindElement(By.XPath("(//span[@class='month ng-binding'])[last()]")).Text.ToString();

            int value1 = 0;
            int value2 = 0;

            switch (m1)
            {
                case "Jan":
                    value1 = 1;
                    break;
                case "Feb":
                    value1 = 2;
                    break;
                case "Mar":
                    value1 = 3;
                    break;
                case "Apr":
                    value1 = 4;
                    break;
                case "May":
                    value1 = 5;
                    break;
                case "Jun":
                    value1 = 6;
                    break;
                case "Jul":
                    value1 = 7;
                    break;
                case "Aug":
                    value1 = 8;
                    break;
                case "Sep":
                    value1 = 9;
                    break;
                case "Oct":
                    value1 = 10;
                    break;
                case "Nov":
                    value1 = 11;
                    break;
                case "Dec":
                    value1 = 12;
                    break;
            }

            switch (m2)
            {
                case "Jan":
                    value2 = 1;
                    break;
                case "Feb":
                    value2 = 2;
                    break;
                case "Mar":
                    value2 = 3;
                    break;
                case "Apr":
                    value2 = 4;
                    break;
                case "May":
                    value2 = 5;
                    break;
                case "Jun":
                    value2 = 6;
                    break;
                case "Jul":
                    value2 = 7;
                    break;
                case "Aug":
                    value2 = 8;
                    break;
                case "Sep":
                    value2 = 9;
                    break;
                case "Oct":
                    value2 = 10;
                    break;
                case "Nov":
                    value2 = 11;
                    break;
                case "Dec":
                    value2 = 12;
                    break;
            }

            if (value1 < value2)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        internal static void VerifyRemovedResident(string value)
        {
            VerifyElement.AreEqual(removedFromSkippedButton, value);
        }
        internal static void VerifyAdmissionDate()
        {
            string a1 = Driver.Instance.FindElement(By.XPath("//ul/li[2]/span[contains(., 'Admission Date Time :')]")).Text.ToString();
            string a2 = Driver.Instance.FindElement(By.XPath("//*[@id='main-content']/div/div[2]/div[1]/ul/li[5]/div/div[2]/div[1]/label")).Text.ToString();
            //Date grab
            string a1Date = a1.Substring(25, 2);
            string a2Date = a2.Substring(6, 2);
            //Year grab
            string a1Year = a1.Substring(28, 4);
            string a2Year = a2.Substring(10, 4);
            try
            {
                Assert.AreEqual(a1Date, a2Date);
            }
            catch (Exception e)
            {

                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual(a1Year, a2Year);
            }
            catch (Exception e)
            {

                VerifyElement.ExceptionLog(e.Message);
            }
        }
        internal static void VerifyAdmissionDateWithinCreateNewMDS()
        {
            // Admission Date within Create New MDS
            string a1 = Driver.Instance.FindElement(By.Id("selectAdmission")).Text.ToString();
            // Admission Date within Schedule page
            string a2 = Driver.Instance.FindElement(By.XPath("//*[@id='main-content']/div/div[2]/div[1]/ul/li[5]/div/div[2]/div[1]/label")).Text.ToString();
            //Date grab
            string a1Date = a1.Substring(3, 2);
            string a2Date = a2.Substring(6, 2);
            //Year grab
            string a1Year = a1.Substring(6, 4);
            string a2Year = a2.Substring(10, 4);
            try
            {
                Assert.AreEqual(a1Date, a2Date);
            }
            catch (Exception e)
            {

                VerifyElement.ExceptionLog(e.Message);
            }
            try
            {
                Assert.AreEqual(a1Year, a2Year);
            }
            catch (Exception e)
            {

                VerifyElement.ExceptionLog(e.Message);
            }
        }
        internal static void VerifyCreateMDSOPtions()
        {
            Driver.ClickOn(createMDSDropdown);
            VerifyElement.AreEqual(removeDropdown, "Remove");
            VerifyElement.AreEqual(historyScheduleDetailsDropdown, "History/Schedule Details");
            Driver.ClickOn(createMDSDropdown);
        }
        internal static void VerifyHistoryScheduleDetailsElements()
        {
            Driver.WaitFor(1);
            string r1 = Driver.Instance.FindElement(By.XPath("(//li[@class='list-group-item ng-scope'])[1]//following-sibling::h4[@class='clickable ng-binding']")).Text.ToString();
            string r2 = Driver.Instance.FindElement(By.XPath("//*[@id='mds']//h3[@class='modal-title ng-binding']")).Text.ToString();
            string resident1 = r1 + " History/Schedule Details";
            //Header displays
            //Icon + Name + History / Schedule Details
            VerifyElement.IsPresent(historyIcon);
            VerifyElement.IsPresent(calendarIcon);
            Assert.AreEqual(resident1, r2);
            //Icon + History
            VerifyElement.IsPresent(iconwithHistory);
            //Assessment Type
            VerifyElement.IsPresent(assessmentTypeHeader);
            //A0050
            VerifyElement.IsPresent(A0050Header);
            //ARD
            VerifyElement.IsPresent(ardHeader);
            //Complete Date
            VerifyElement.IsPresent(completedDateHeader);
            //Rug Score
            VerifyElement.IsPresent(rugScoreHeader);
            //Status
            VerifyElement.IsPresent(statusHeader);
            //Batch #,
            VerifyElement.IsPresent(batchHeader);
            //Date
            VerifyElement.IsPresent(batchDateHeader);
            //Admission Date
            VerifyElement.IsPresent(admissionDate);
            //RESET SCHEDULE button
            VerifyElement.IsPresent(resetScheduleButton);
            //Icon + Schedule
            VerifyElement.IsPresent(schduleIcon);
            //Assessment Type
            VerifyElement.IsPresent(assessmentTypeHeader2);
            //ARD
            VerifyElement.IsPresent(ardHeader2);
            //Complete By Date(Z0500B)
            VerifyElement.IsPresent(completeByDateZ0500BHeader);
            //CAA Complete By(V0200B2)"
            VerifyElement.IsPresent(cAACompleteByV0200B2Header);
        }
        internal static void VerifyOBRAassessmentType()
        {
            try
            {
                VerifyElement.IsNotPresent(ppsFilterButtonChecked);
                VerifyElement.IsPresent(obraFilterButtonChecked);
                // Admission
                if (Driver.IsElementPresent(admissionAssessment))
                {
                    VerifyElement.IsPresent(admissionAssessment);
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    VerifyElement.IsPresent(admissionAssessment);
                    Driver.ClickOn(previousPagination);
                }
                // Quarterly
                if (Driver.IsElementPresent(quarterlyAssessment))
                {
                    VerifyElement.IsPresent(quarterlyAssessment);
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    VerifyElement.IsPresent(quarterlyAssessment);
                    Driver.ClickOn(previousPagination);
                }
                VerifyElement.IsNotPresent(SchedulePage.fivedayAssessment);
                VerifyElement.IsNotPresent(SchedulePage.fourteendayAssessment);
                VerifyElement.IsNotPresent(SchedulePage.thirtydayAssessment);
                VerifyElement.IsNotPresent(SchedulePage.sixtydayAssessment);
                VerifyElement.IsNotPresent(SchedulePage.ninetydayAssessment);
            }
            catch (Exception)
            {

                throw;
            }
        }
        internal static void VerifyPPSassessmentType()
        {
            VerifyElement.IsNotPresent(obraFilterButtonChecked);
            VerifyElement.IsPresent(ppsFilterButtonChecked);
            VerifyElement.IsNotPresent(admissionAssessment);
            VerifyElement.IsNotPresent(quarterlyAssessment);
            // 5 day
            if (Driver.IsElementPresent(fivedayAssessment))
            {
                VerifyElement.IsPresent(fivedayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(fivedayAssessment);
                Driver.ClickOn(previousPagination);
            }
            // 14 day
            if (Driver.IsElementPresent(fourteendayAssessment))
            {
                VerifyElement.IsPresent(fourteendayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                if (Driver.IsElementPresent(fourteendayAssessment))
                {
                    VerifyElement.IsPresent(fourteendayAssessment);
                    Driver.ClickOn(previousPagination);
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    VerifyElement.IsPresent(fourteendayAssessment);
                    Driver.ClickOn(previousPagination);
                }
            }
            // 30 day
            if (Driver.IsElementPresent(thirtydayAssessment))
            {
                VerifyElement.IsPresent(thirtydayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(thirtydayAssessment);
                Driver.ClickOn(previousPagination);
            }
            // 60 day
            if (Driver.IsElementPresent(sixtydayAssessment))
            {
                VerifyElement.IsPresent(sixtydayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(sixtydayAssessment);
                Driver.ClickOn(previousPagination);
            }
            // 90 day
            if (Driver.IsElementPresent(ninetydayAssessment))
            {
                VerifyElement.IsPresent(ninetydayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(ninetydayAssessment);
                Driver.ClickOn(previousPagination);
            }
        }
        internal static void VerifyBBRAandPPSassessmentType()
        {
            VerifyElement.IsNotPresent(obraFilterButtonChecked);
            VerifyElement.IsNotPresent(ppsFilterButtonChecked);

            // Admission
            if (Driver.IsElementPresent(admissionAssessment))
            {
                VerifyElement.IsPresent(admissionAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(admissionAssessment);
                Driver.ClickOn(previousPagination);
                Driver.WaitFor(1);
            }
            // Quarterly
            if (Driver.IsElementPresent(quarterlyAssessment))
            {
                VerifyElement.IsPresent(quarterlyAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(quarterlyAssessment);
                Driver.ClickOn(previousPagination);
                Driver.WaitFor(1);
            }
            // 5 day
            if (Driver.IsElementPresent(fivedayAssessment))
            {
                VerifyElement.IsPresent(fivedayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(fivedayAssessment);
                Driver.ClickOn(previousPagination);
                Driver.WaitFor(1);
            }
            // 14 day
            if (Driver.IsElementPresent(fourteendayAssessment))
            {
                VerifyElement.IsPresent(fourteendayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                if (Driver.IsElementPresent(fourteendayAssessment))
                {
                    VerifyElement.IsPresent(fourteendayAssessment);
                    Driver.ClickOn(previousPagination);
                    Driver.WaitFor(1);
                }
                else
                {
                    Driver.ClickOn(nextPagination);
                    VerifyElement.IsPresent(fourteendayAssessment);
                    Driver.ClickOn(previousPagination);
                    Driver.WaitFor(1);
                }
            }
            // 30 day
            if (Driver.IsElementPresent(thirtydayAssessment))
            {
                VerifyElement.IsPresent(thirtydayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(thirtydayAssessment);
                Driver.ClickOn(previousPagination);
                Driver.WaitFor(1);
            }
            // 60 day
            if (Driver.IsElementPresent(sixtydayAssessment))
            {
                VerifyElement.IsPresent(sixtydayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(sixtydayAssessment);
                Driver.ClickOn(previousPagination);
                Driver.WaitFor(1);
            }
            // 90 day
            if (Driver.IsElementPresent(ninetydayAssessment))
            {
                VerifyElement.IsPresent(ninetydayAssessment);
            }
            else
            {
                Driver.ClickOn(nextPagination);
                VerifyElement.IsPresent(ninetydayAssessment);
                Driver.ClickOn(previousPagination);
                Driver.WaitFor(1);
            }

        }
        internal static void VerifyResetScheduleWindowElements()
        {
            VerifyElement.IsPresent(resetIcon);
            VerifyElement.AreEqual(resetOBRAScheduleHeader, "Reset OBRA Schedule");
            VerifyElement.AreEqual(resetOBRAScheduleNote, "Select admission date you want OBRA schedule to start from:");
            VerifyElement.IsPresent(resetScheduleCancelBtn);
            VerifyElement.IsPresent(resetScheduleResetBtn);
        }
        #endregion

        #region Navigation
        public static void NavigateToLandingPage()
        {
            Driver.PressEnter(UserMenu.homeIcon);
            VerifyElement.IsPresent(LandingPage.scheduleTile);
        }
        internal static void NavigateToResidentsDemographics()
        {
            Driver.PressEnter(firstResidentfromList);
            VerifyElement.AreEqual(residentsDemographicsHeader, "Resident's Demographics");
        }
        internal static void NavigateToResidentsDemographicsLastResident()
        {
            Driver.PressEnter(lastResidentfromList);
            VerifyElement.AreEqual(residentsDemographicsHeader, "Resident's Demographics");
        }

        internal static void NavigateToLastPage()
        {
            try
            {
                Driver.WaitFor(1);
                Driver.ClickOn(By.XPath("//li[@class='pagination-page ng-scope'][last()]/a"));
            }
            catch (AssertionException e)
            {
                throw e;
            }
        }

        internal static void NavigateToResidentsHistoryPage(string v)
        {
            Driver.ClickOn(By.XPath("(//li[@class='list-group-item ng-scope']//div[@class='initials-circle'])[" + v + "]"));
            Driver.WaitFor(2);
            VerifyElement.AreEqual(ResidentsHistoryPage.pageHeader, "Resident's History");
        }

        #endregion

    }
}
