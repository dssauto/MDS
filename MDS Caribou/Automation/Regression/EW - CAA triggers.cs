using Automation.POM;
using Framework.Base;
using Framework.Helper;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EW__0CAA_triggers
    {
        [Test]
        public void EW_CAA_triggers()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1 Precondition for CAT 8(step 45) "Precondition for Step 45 for CAT 8-  these assessments are different than the one used for all the other CATs
            //Complete an Admission assessment and ensure the answers in D0200 make the score in D0300 less than or equal to 10.
            //sign it, seal, batch, mark as accepted.
            //Open a significant change for same resident. ARD after the ARD of Admission assessment.
            //make sure answers in D0200 make the score in D0300 higher than 10.  (this will trigger CAT 8 on section V)"
            //Step 2  CAT 1   "GO TO AN ADMISSION ASSESSMENT FOR ALL STEPS
            //GO TO SECTION V
            //VALIDATE THAT DELIRIUM CAT 1 IS NOT TRIGGERED.THERE IS NO CHECK MARK IN COLUMN V0200A1A"
            //Step 3 CAT 1 - spec changes * *"DELIRIUM CAT 1
            //GO TO AN ADMISSION ASSESSMENT
            //CLICK ON SECTION C
            //ANSWER THE FOLLOWING:
            //C1310A = 1
            //C1310B = 1
            //C1310C = 1
            //GO TO SECTION V AND VALIDATE THAT DELIRIUM CAT HAS A CHECKMARK IN COLUMN V0200A1A"
            //Step 4  CAT 1   "DELIRIUM CAT 1
            //GO TO ADMISSION ASSESSMENT
            //GO TO SECTION C
            //ANSWER THE FOLLOWING:
            //C1310A = 1
            //C1310B = 2
            //C1310D = 1
            //GO TO SECTION V AND VALIDATE DELIRIUM CAT HAS A CHECKMARK IN COLUMN V0200A1A"
            //Step 5  CAT 1   "DELIRIUM CAT 1
            //GO TO ADMISSION ASSESSMENT
            //GO TO SECTION C
            //ANSWER  THE FOLLOWING:
            //C1310A = 1
            //C1310B = 1
            //C1310D = 2
            //GO TO SECTION V AND VALIDATE DELIRIUM CAT HAS A CHECKMARK IN COLUMN V0200A1A"
            //Step 6 CAT 2    "COGNITIVE LOSS/DEMENTIA CAT 2
            //GO TO ADMISSION ASSESSMENT
            //GO TO SECTION V AND VALIDATE THAT THE COGNITIVE LOSS / DEMENTIA CAT HAS NO CHECKMARK IN V0200A2A"
            //Step 7 CAT 2    "GO TO SECTION C0200 CO300 AND CO400 AND DASH ALL THE ANSWERS.
            //VERIFIY THAT C0500 = 99 OR IS DASHED.
            //GO TO V0200A2A AND VERIFY CAT 2 IS CHECKED."

            //    "COGNITIVE LOSS/DEMENTIA CAT 2
            //GO TO ADMISSION ASSESSMENT
            //GO TO SECTION C
            //ANSWER AS FOLLOWS:
            //C0200 = 1
            //C0300A = 1
            //C0300B = 1
            //C0300C = 0
            //C0400A = 0
            //C0400B = 0
            //C0400C = 1
            //NOTE THAT THE SCORE IN C0500 IS LESS THAT 13
            //GO TO SECTION V AND VALIDATE THAT THERE IS A CHECKMARK IN V0200A2"
            //Step 9 CAT 2    REMOVE ANSWERS FROM SECTION C TO REMOVE CHECKMARK FROM V0200A2A
            //Step 10 CAT 2   "COGNITIVE LOSS/DEMENTIA CAT 2
            //GO TO ADMISSION ASSESSMENT
            //GO TO SECTION E
            //ANSWER AS FOLLOWS:
            //E0200A = 1 OR 2 OR 3
            //OR
            //E0200B = 1 OR 2 OR 3
            //OR
            //E0200C = 1 OR 2 OR 3
            //GO TO SECTION V AND VALIDATE THAT V0200A2A HAS A CHECKMARK"
            //Step 11 CAT 2   REMOVE ANSWERS FROM SECTION E0200 AND VERIFY THAT CAT 2 HAS NO CHECKMARK ON SECTION V0200A2A
            //Step 12 CAT 2, 9    "COGNITIVE LOSS/DEMENTIA  CAT 2
            //BEHAVIORAL SYMPTOMS CAT 9
            //GO TO ADMISSION ASSESSMENT
            //GO TO SECTION E0800
            //ANSWER AS FOLLOWS
            //E0800 = 1 OR 2 OR 3
            //GO TO SECTION V
            //VERIFY V0200A2A AND V0200A9A HAVE A CHECKMARK"
            //Step 13 CAT 2, 9    REMOVE THE ANSWER FROM E0800 AND VERIFY THE CHECKMARKS ARE GONE FROM V0200A2A AND V0200A9A
            //Step 14 CAT 2, 9    "COGNITIVE LOSS/DEMENTIA  CAT 2
            //BEHAVIORAL SYMPTOMS CAT 9
            //GO TO ADMISSION ASSESSMENT
            //GO TO SECTION E0900
            //ANSWER AS FOLLOWS
            //E0900 = 1 OR 2 OR 3
            //GO TO SECTION V AND VERIFY V0200A2A AND V0200A9A HAVE A CHECKMARK"
            //Step 15 CAT 3   "VISUAL FUNCTION CAT 3
            //GO TO ADMISSION ASSESSMENT
            //GO TO SECTION V0200A3A AND VERIFY THERE IS NO CHECKMARK"
            //Step 16 CAT 3   "VISUAL FUNCTION CAT 3
            //GO TO ADMISSION ASSESSMENT
            //GO TO SECTION B
            //ANSWER AS FOLLOWS:
            //B1000 = 1 OR 2 OR 3 OR 4
            //GO TO V0200A3A AND VERIFY THERE IS A CHECKMARK"
            //Step 17 CAT 3   "REMOVE ANSWERS FROM SECTION B
            //GO TO V0200A3A AND VERIFY THERE IS NO CHECKMARK"
            //Step 18 CAT 3   "GO TO SECTION I6500 AND CHECK THE BOX
            //GO TO V0200A3A AND VERIFY THERE IS A CHECKMARK"
            //Step 19 CAT 4   "COMMUNICATION CAT 4
            //GO TO SECTION V0200A4A AND VERIFY CAT 4 IS NOT CHECKED"
            //Step 20 CAT 4   "COMMUNICATION CAT 4
            //GO TO SECTION B0200
            //ANSWER AS FOLLOWS:
            //B0200 = 1 OR 2 OR 3
            //GO TO V0200A4A AND VERIFY THERE IS A CHECKMARK"
            //Step 21 CAT 4   "REMOVE ANSWER FROM B0200
            //VERIFY CHECKMARK IS REMOVED FROM V0200A4A"
            //Step 22 CAT 4   "COMMUNICATION
            //GO TO SECTION B0700
            //ANSWER AS FOLLOWS:
            //BO700 - 1 OR 2 OR 3
            //VALIDATE THE CHECKMARK ON V0200A4 DISPLAYS"
            //Step 23 CAT 4   "REMOVE ANSWER FROM B0700
            //VALIDATE CHECKMARK IS GONE ON V0200A4A"
            //Step 24 CAT 4   "CONNUMICATION
            //GO TO B0800
            //ANSWER AS FOLLOWS:
            //B0800 = 1 OR 2 OR 3
            //VALIDATE CHECKMARK DISPLAYS ON V0200A4A"
            //Step 25 CAT 5   "ADL FUNCTIONAL/REHABILITATION POTENTIAL CAT 5
            //GO TO V0200A5A AND VERIFY THERE IS NO CHECKMARK"
            //Step 26 CAT 5   "ADL FUNCTIONAL/REHABILITATION POTENTIAL CAT 5
            //CAT 5 USES SECTION C AND G TO CALCULATE THE TRIGGER
            //GO TO SECTION C
            //ANSWER AS FOLLOWS:
            //C0200 = 1
            //C0300A = 1
            //C0300B = 1
            //C0300C = 0
            //C0400A = 0
            //C0400B = 0
            //C0400C = 0
            //NOTE THE SCORE ON C0500 IS BETWEEN 05 - 15
            //GO TO SECTION G
            //ANSWER AS FOLLOWS:
            //G0110A1 = 1 OR 2 OR 3 OR 4
            //GO TO SECTION V0200A5A AN VALIDATE THE CHECKMARK DISPLAYS"
            //Step 27 CAT 5   "UNCHECK ANSWER FROM G0100A1 ONLY. LEAVE ANSWERS IN SECTION C.
            //VERIFY THAT CAT 5 IS UNCHECKED"
            //Step 28 CAT 5   "GO TO G0110B1 AND ANSWER 1 OR 2 OR 3 OR 4
            //VERIFY V0200A5A IS CHECKED"
            //Step 29 CAT 5   "UNCHECK ANSWER FROM G0100B1 ONLY. LEAVE ANSWERS IN SECTION C.
            //VERIFY THAT CAT 5 IS UNCHECKED"
            //Step 30 CAT 5   "GO TO G0110H1 AND ANSWER 1 OR 2 OR 3 OR 4
            //VERIFY V0200A5A IS CHECKED"
            //Step 31 CAT 5   "UNCHECK ANSWER FROM G0100H1 ONLY. LEAVE ANSWERS IN SECTION C.
            //VERIFY THAT CAT 5 IS UNCHECKED"
            //Step 32 CAT 5, 6    "THIS STEP VALIDATES CAT 5 (ADL FUNCTIONAL/REHABILITATION POTENTIAL) AND CAT 6 (URINARY INCONTINENCE)
            //GO TO G0110 I 1 AND ANSWER 2 OR 3 OR 4
            //VERIFY V0200A5A IS CHECKED
            //VERIFY V0200A6A IS CHECKED"
            //Step 33 CAT 5, 6    "UNCHECK ANSWER FROM G0110 I 1 ONLY. LEAVE ANSWERS IN SECTION C.
            //VERIFY THAT CAT 5 AND CAT 6 ARE UNCHECKED"
            //Step 34 CAT 5   "GO TO SECTION G0120A AND ANSWER 1 OR 2 OR 3 OR 4
            //VERIFY V0200A5A HAS A CHECKMARK"
            //Step 35 CAT 5   "UNCHECK ANSWER FROM G0120A ONLY. LEAVE ANSWERS IN SECTION C.
            //VERIFY THAT CAT 5 IS UNCHECKED"
            //Step 36 CAT 5   "GO TO SECTION G0300B AND ANSWER 1 OR 2
            //GO TO SECTION G0300C AND ANSWER 1 OR 2
            //VERIFY V0200A5A IS CHECKED"
            //Step 37 CAT 5   "UNCHECK ANSWERS FROM G0300B AND G0300C ONLY. LEAVE ANSWERS IN SECTION C.
            //VERIFY THAT CAT 5 IS UNCHECKED"
            //Step 38 CAT 5   "GO TO G0900A AND B AND ANSWER=1
            //VERIFY V0200A5A IS CHECKED."
            //Step 39 CAT 6   "URINARY INCONTINENCE AND INDWELLING CATHETER CAT 6
            //GO TO SECTION H0100A OR B OR D = CHECKED
            //VERIFY V0200A6A IS CHECKED."
            //Step 40 CAT 6   "REMOVE THE ANSWER FROM H0100
            //VERIFY CAT 6 IS UNCHECKED ON V0200A6A"
            //Step 41 CAT 6   "GO TO H0300 AND ANSWER 1 OR 2 OR 3
            //VERIFY V0200A6A IS CHECKED"
            //Step 42 CAT 6   "REMOVE ANSWER FROM H0300
            //VERIFY CHECKMARK IS REMOVED FROM V0200A6A"
            //Step 43 CAT 6   "GO TO M1040H
            //ANSWER = CHECKED
            //VERIFY V0200A6A IS CHECKED"
            //Step 44 CAT 7, 10  "PSYCHOSOCIAL WELL-BEING CAT 7
            //ACTIVITIES CAT 10
            //GO TO F0500A, B, C, F, G, H
            //ANSWER = 4
            //GO TO F0600 ANSWER = 1
            //VERIFY CAT 7(V0200A7A) AND CAT 10 V0200A10A) ARE CHECKED."
            //Step 45 CAT 8 WITH PRE-CONDITIONS   "Precondition for MOOD STATE, CAT 8-  these assessments for CAT 8 are different than the one used for all the other CATs
            //Complete an Admission assessment and ensure the answers in D0200 make the score in D0300 less than or equal to 10.
            //sign it, seal, batch, mark as accepted.
            //Open a significant change for same resident. ARD after the ARD of Admission assessment.
            //make sure answers in D0200 make the score in D0300 higher than 10.  (this will trigger CAT 8 on section V)"
            //Step 46 CAT 9   "BEHAVIORAL SYMPTOMS CAT 9
            //GO TO E0200 A, B AND C
            //ANSWER = 1 OR 2 OR 3
            //GO TO E0300 AND ANSWER = 1
            //VERIFY V0200A9A IS CHECKED"
            //Step 47 CAT 11, 17  "FALLS CAT 11
            //PSYCHOTROPIC DRUG USE CAT 17
            //GO TO SECTION E0900
            //ANSWER = 2
            //GO TO SECTION N0410B
            //ANSWER = 3
            //VERIFY V0200A11A AND V0200A17A HAVE A CHECKMARK"
            //Step 48 CAT 12 DASHES   "NUTRITIONAL STATUS CAT 12
            //GO TO SECTION K0200 AND ANSWER DASH FOR A AND B.
            //VERIFY THAT V0200A12A IS NOT CHECKED"
            //Step 49 CAT 12  "NUTRITIONAL STATUS CAT 12
            //GO TO SECTION J1550C = CHECKED
            //VERIFY V0200A12A IS CHECKED
            //UNCHECK J1550C IN PREPARATION FOR NEXT STEP"
            //Step 50 CAT 12, 16  "NUTRITIONAL STATUS CAT 12
            //PRESSURE ULCER CAT 16
            //GO TO SECTION M0300B1 = 9
            //VERIFY V0200A12A AND V0200A16A ARE CHECKED
            //REMOVE ANSWERS FOR OTHER STEPS"
            //Step 51 CAT 13, 14  "FEDING TUBES CAT 13
            //DEHYDRATION / FLUID MAINTENANCE CAT 14
            //GO TO SECTION K0510B2 = 1
            //VERIFY V0200A13A  AND V0200A14A ARE CHECKED
            //REMOVE ANSWERS FOR NEXT STEP"
            //Step 52 CAT 14  "DEHYDRATION/FLUID MAINTENANCE CAT 14
            //GO TO SECTION I2300 = CHECKED
            //VERIFY V0200A14A IS CHECKED
            //REMOVE ANSWER FOR NEXT STEP"
            //Step 53 CAT 14  "DEHYDRATION/FLUID MAINTENANCE CAT 14
            //GO TO SECTION M1040A = CHECKED
            //VERIFY V0200A14A IS CHECKED"
            //Step 54 CAT 15  "DENTAL CARE CAT 15
            //GO TO SECTION L0200A - F ANY ARE ANSWERED WITH A CHECK.
            //VERIFY V0200A15A IS CHECKED"
            //Step 55 CAT 16  "PRESSURE ULCER CAT 16
            //GO TO SECTION G0110A1 = 8
            //VERIFY V0200A16A IS CHECKED"
            //Step 56 CAT 18  "PHYSICAL RESTRAINTS CAT 18
            //GO TO SECTION P0100H = 2
            //VERIFY V0200A18A IS CHECKED"
            //Step 57 CAT 19  "PAIN CAT 19
            //GO TO SECTION J0400 = 2
            //AND J0600A = 09
            //VERIFY V0200A19A IS CHECKED
            //REMOVE ANSWERS FOR NEXT STEP"
            //Step 58 CAT 19  "PAIN CAT 19
            //GO TO SECTION JO800D = CHECKED
            //VERIFY V0200A19A IS CHECKED"
            //Step 59 CAT 20  "RETURN TO COMMUNITY REFERRAL CAT 20
            //GO TO SECTION Q0600 = 1
            //VERIFY V0200A20A IS CHECKED"
        }
    }
}
