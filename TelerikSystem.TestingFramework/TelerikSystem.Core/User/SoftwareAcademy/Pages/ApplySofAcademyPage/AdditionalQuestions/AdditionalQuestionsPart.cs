namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.AdditionalQuestions
{
    using System;
    using System.Linq;

    using TestingFramework.Core.Base;

    public class AdditionalQuestionsPart : BasePage<AdditionalQuestionsPartMap, ApplySofAcademyPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/SoftwareAcademy/Candidate";
            }
        }
    }
}