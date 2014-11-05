namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage
{
    using System;
    using ArtOfTest.Common.UnitTesting;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.AcceptPolicy;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.AdditionalQuestions;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.Documents;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.PersonalInfo;
    using TestingFramework.Core.Base;
    
    public class ApplySofAcademyPageValidator
    {
        private readonly string errorMessageQ9 = "Моля отговорете на въпроса 'Откъде научихте за програмата Telerik Software Academy?'";
        private readonly string errorMessageQ9AddFields = "Моля попълнете допълнителните полета на въпроса 'Откъде научихте за програмата Telerik Software Academy?'";
        private readonly string errorMessageQ10 = "Моля отговорете на въпроса 'Кандидатствали ли сте преди в Софтуерната академия на Телерик?'";
        private readonly string errorMessageQ11 = "Моля отговорете на въпроса 'С какво най-вече свързвате компанията Телерик?'";
        
        public void AssertIsNotInCandidatePeriod()
        {
            Assert.IsTrue(
                Pages<ApplySofAcademyPage>.Instance
                                          .Map
                                          .MainContent
                                          .InnerText
                                          .Contains("За съжаление периодът на кандидатстване за академията изтече."));
        }

        public void AssertIsInCandidatePeriod()
        {
            Assert.IsTrue(
                Pages<ApplySofAcademyPage>.Instance
                                          .Map
                                          .MainContent
                                          .InnerText
                                          .Contains("Кандидатстване за \"Софтуерната академия на Телерик\""));
        }

        #region[q09:Откъде научихте за програмата Telerik Software Academy?]

        public void AssertMainMessageCantApplyQ09_NoSelection()
        {
            this.NoSelection_Q09();
            Assert.IsTrue(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(this.errorMessageQ9), "Something has to be selected");
        }

        public void AssertLocalMessageCantApplyQ09_NoSelection()
        {
            this.NoSelection_Q09();
            Assert.IsTrue(Pages<AdditionalQuestionsPart>.Instance.Map.Q9LocalMessage.InnerText.Contains(this.errorMessageQ9AddFields), "Something has to be selected");
        }

        public void AssertMainMessageCantApplyAsQ09_Selected()
        {
            this.Selected_Q09_Q10_Q11();
            Assert.IsFalse(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(this.errorMessageQ9));
        }

        public void AssertLocalMessageCantApplyAsQ09_Selected()
        {
            this.Selected_Q09_Q10_Q11();
            Assert.IsFalse(Pages<AdditionalQuestionsPart>.Instance.Map.Q10LocalMessage.InnerText.Contains(this.errorMessageQ9));
        }

        public void AssertMainMessageCantApplyQ09_InvalidInputData(string invalidData, int numberAnswer)
        {
            this.Apply_DifferentData_Q09(invalidData, numberAnswer);
            Pages<AcceptTermsPart>.Instance.Map.AcceptTerms.Click();
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();

            Assert.IsTrue(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(this.errorMessageQ9AddFields), string.Format("{0} is invalid input", invalidData));
        }

        public void AssertMainMessageCantApplyQ09_ValidInputData(string validData, int numberAnswer)
        {
            this.Apply_DifferentData_Q09(validData, numberAnswer);
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();

            Assert.IsFalse(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(this.errorMessageQ9AddFields), string.Format("{0} is invalid input", validData));
        }

        public void AssertLocalMessageCantApplyQ09_InvalidInputData(string invalidData, int numberAnswer)
        {
            this.Apply_DifferentData_Q09(invalidData, numberAnswer);
            Pages<AcceptTermsPart>.Instance.Map.AcceptTerms.Click();
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();

            Assert.IsTrue(Pages<AdditionalQuestionsPart>.Instance.Map.Q9LocalMessage.InnerText.Contains(this.errorMessageQ9AddFields), string.Format("{0} is invalid input", invalidData));
        }

        public void AssertLokalMessageCantApplyQ09_ValidInputData(string validData, int numberAnswer)
        {
            this.Apply_DifferentData_Q09(validData, numberAnswer);
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();

            Assert.IsFalse(Pages<AdditionalQuestionsPart>.Instance.Map.Q9LocalMessage.InnerText.Contains(this.errorMessageQ9AddFields), string.Format("{0} is invalid input", validData));
        }

        #endregion

        #region[q10:Кандидатствали ли сте преди в Софтуерната академия на Телерик?]
        public void AssertMainMessageCantApplyAsQ10_NoSelection()
        {
            this.NoSelection_Q10();
            Assert.IsTrue(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(this.errorMessageQ10));
        }

        public void AssertLocalMessageCantApplyAsQ10_NoSelection()
        {
            this.NoSelection_Q10();
            Assert.IsTrue(Pages<AdditionalQuestionsPart>.Instance.Map.Q10LocalMessage.InnerText.Contains(this.errorMessageQ10));
        }

        public void AssertMainMessageCantApplyAsQ10_Selected()
        {
            this.Selected_Q09_Q10_Q11();
            Assert.IsFalse(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(this.errorMessageQ10));
        }

        public void AssertLocalMessageCantApplyAsQ10_Selected()
        {
            this.Selected_Q09_Q10_Q11();
            Assert.IsFalse(Pages<AdditionalQuestionsPart>.Instance.Map.Q10LocalMessage.InnerText.Contains(this.errorMessageQ10));
        }
        #endregion

        #region[q11:С какво най-вече свързвате компанията Телерик?]
        public void AssertMainMessageCantApplyAsQ11_NoSelection()
        {
            this.NoSelection_Q11();
            Assert.IsTrue(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(this.errorMessageQ11));
        }

        public void AssertLocalMessageCantApplyAsQ11_NoSelection()
        {
            this.NoSelection_Q11();
            Assert.IsTrue(Pages<AdditionalQuestionsPart>.Instance.Map.Q11LocalMessage.InnerText.Contains(this.errorMessageQ11));
        }

        public void AssertMainMessageCantApplyAsQ11_Selected()
        {
            this.Selected_Q09_Q10_Q11();
            Assert.IsFalse(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(this.errorMessageQ11));
        }

        public void AssertLocalMessageCantApplyAsQ11_Selected()
        {
            this.Selected_Q09_Q10_Q11();
            Assert.IsFalse(Pages<AdditionalQuestionsPart>.Instance.Map.Q11LocalMessage.InnerText.Contains(this.errorMessageQ11));
        }

#endregion

        #region[help]
        public void Selected_Q09_Q10_Q11()
        {
            string validInput = "асдфг";
            this.FullfilPersolalDataAndDocument();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q1Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q2Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q3Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q4Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q5Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q6Checkbox1.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q7Checkbox9.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q8Checkbox16.Click();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31Text.Text = validInput;

            Pages<AdditionalQuestionsPart>.Instance.Map.Q10RadioButton39.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q11RadioButton42.Click();

            Pages<AcceptTermsPart>.Instance.Map.AcceptTerms.Click();
        }

        private void Apply_DifferentData_Q09(string insetDataTestInput, int numberAnswer)
        {
            string validInput = "асдфг";
            this.FullfilPersolalDataAndDocument();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q1Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q2Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q3Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q4Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q5Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q6Checkbox1.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q7Checkbox9.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q8Checkbox16.Click();

            Pages<AdditionalQuestionsPart>.Instance.Map.FindAnswerCheckbox(numberAnswer).Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.FindInputBox(numberAnswer).Text = insetDataTestInput;

            Pages<AdditionalQuestionsPart>.Instance.Map.Q10RadioButton39.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q11RadioButton42.Click();
        }

        private void NoSelection_Q09()
        {
            string validInput = "асдфг";
            this.FullfilPersolalDataAndDocument();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q1Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q2Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q3Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q4Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q5Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q6Checkbox1.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q7Checkbox9.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q8Checkbox16.Click();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q10RadioButton39.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q11RadioButton42.Click();

            Pages<AcceptTermsPart>.Instance.Map.AcceptTerms.Click();
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();
        }

        private void NoSelection_Q10()
        {
            string validInput = "асдфг";
            this.FullfilPersolalDataAndDocument();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q1Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q2Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q3Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q4Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q5Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q6Checkbox1.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q7Checkbox9.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q8Checkbox16.Click();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31Text.Text = validInput;

            Pages<AdditionalQuestionsPart>.Instance.Map.Q11RadioButton42.Click();

            Pages<AcceptTermsPart>.Instance.Map.AcceptTerms.Click();
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();
        }

        private void NoSelection_Q11()
        {
            string validInput = "асдфг";
            this.FullfilPersolalDataAndDocument();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q1Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q2Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q3Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q4Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q5Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q6Checkbox1.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q7Checkbox9.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q8Checkbox16.Click();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31Text.Text = validInput;

            Pages<AdditionalQuestionsPart>.Instance.Map.Q10RadioButton39.Click();

            Pages<AcceptTermsPart>.Instance.Map.AcceptTerms.Click();
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();
        }
      
        private void FullfilPersolalDataAndDocument()
        {
            Pages<PersonalInfoPart>.Instance.SetValidInputPersonalInfo();
            Pages<DocumentsPart>.Instance.SetValidDocuments();
        }
        #endregion
    }
}