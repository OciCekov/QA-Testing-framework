namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.CreateNewExamPage
{
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.MainPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    public class NewExamPage : BasePage<NewExamPageMap, NewExamPageValidator>
    {
        public override string Url
        {
            get { return @"http://test.telerikacademy.com/Administration_SoftwareAcademy/CandidateExams"; }
        }

        public override void Navigate()
        {
            base.Navigate();
            Pages<EntranceExamPage>.Instance.Map.GetToExams.Click();
        }

        //TODO Add Parameters 
        public void CreateNewExam(string start, string end, string iqConfigId, string itConfigId, string enConfigId,
            string students, string hall)
        {
            this.Map.IqConfigurationId.Find.AllByTagName<HtmlListItem>("li")
                .FirstOrDefault(li => li.InnerText == iqConfigId)
                .Click();
            this.Map.ItConfigurationId.Find.AllByTagName<HtmlListItem>("li")
                .FirstOrDefault(li => li.InnerText == itConfigId)
                .Click();
            this.Map.EnglishTestConfigurationId.Find.AllByTagName<HtmlListItem>("li")
                .FirstOrDefault(li => li.InnerText == enConfigId)
                .Click();

            this.Map.StartTime.MouseClick();
            this.Map.StartTime.Value = "";
            this.Map.StartTime.OwnerBrowser.Desktop.KeyBoard.TypeText(start, 1);

            this.Map.StartTime.OwnerBrowser.Desktop.KeyBoard.KeyPress(Keys.Tab);
            this.Map.EndTime.Value = "";
            this.Map.EndTime.OwnerBrowser.Desktop.KeyBoard.TypeText(end, 1);

            this.Map.TrainingRoomOption.Find.AllByTagName<HtmlListItem>("li")
                .FirstOrDefault(li => li.InnerText == students)
                .Click();

            this.Map.StudentsLimit.Text = students;
            this.Map.StudentsLimit.FireChange();
            Thread.Sleep(1000);
            this.Map.UpdateButton.FireClick();
            Thread.Sleep(1000);
        }

        public void CreateNewExam(string startTime, string endTime)
        {
            this.Map.IqConfigurationId.Find.AllByTagName<HtmlListItem>("li")[1].Click();
            this.Map.ItConfigurationId.Find.AllByTagName<HtmlListItem>("li")[2].Click();
            this.Map.EnglishTestConfigurationId.Find.AllByTagName<HtmlListItem>("li")[3].Click();

            this.Map.StartTime.MouseClick();
            this.Map.StartTime.Value = "";
            this.Map.StartTime.OwnerBrowser.Desktop.KeyBoard.TypeText(startTime, 1);

            this.Map.StartTime.OwnerBrowser.Desktop.KeyBoard.KeyPress(Keys.Tab);
            this.Map.EndTime.Value = "";
            this.Map.EndTime.OwnerBrowser.Desktop.KeyBoard.TypeText(endTime, 1);

            this.Map.TrainingRoomOption.Find.AllByTagName<HtmlListItem>("li")[1].Click();

            this.Map.StudentsLimit.Text = "37";
            this.Map.StudentsLimit.FireChange();
            Thread.Sleep(1000);
            this.Map.UpdateButton.FireClick();
            Thread.Sleep(1000);
        }
    }
}