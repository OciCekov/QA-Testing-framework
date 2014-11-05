namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.MainPage
{
    using TestingFramework.Core.Base;

    public class EntranceExamPage : BasePage<EntranceExamPageMap, EntranceExamPageValidator>
    {
        public override string Url
        {
            get { return @"http://test.telerikacademy.com/Administration_SoftwareAcademy/CandidateExams"; }
        }
    }
}