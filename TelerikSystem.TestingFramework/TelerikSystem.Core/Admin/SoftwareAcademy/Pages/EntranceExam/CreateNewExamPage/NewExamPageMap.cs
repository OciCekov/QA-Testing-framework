namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.CreateNewExamPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class NewExamPageMap : BaseElementMap
    {
        public HtmlUnorderedList IqConfigurationId
        {
            get { return this.Find.ById<HtmlUnorderedList>("IQTestConfigurationId_listbox"); }
        }

        public HtmlUnorderedList ItConfigurationId
        {
            get { return this.Find.ById<HtmlUnorderedList>("ITTestConfigurationId_listbox"); }
        }

        public HtmlUnorderedList EnglishTestConfigurationId
        {
            get { return this.Find.ById<HtmlUnorderedList>("EnglishTestConfigurationId_listbox"); }
        }

        public HtmlInputText StartTime
        {
            get { return this.Find.ById<HtmlInputText>("StartTime"); }
        }

        public HtmlInputText EndTime
        {
            get { return this.Find.ById<HtmlInputText>("EndTime"); }
        }

        public HtmlUnorderedList TrainingRoomOption
        {
            get { return this.Find.ById<HtmlUnorderedList>("TrainingRoomId_listbox"); }
        }

        public HtmlInputText AllowedIps
        {
            get { return this.Find.ById<HtmlInputText>("AllowedIp"); }
        }

        public HtmlInputNumber StudentsLimit
        {
            get { return this.Find.ById<HtmlInputNumber>("CandidatesCountLimit"); }
        }

        public HtmlAnchor UpdateButton
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Update"); }
        }

        public HtmlAnchor CancelButton
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Cancel"); }
        }

        public HtmlAnchor CloseWindowButton
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Close"); }
        }

        public HtmlSpan WindowTitle
        {
            get
            {
                return this.Find.AllByTagName<HtmlSpan>("span")
                    .FirstOrDefault(sp => sp.InnerText == "Изпит в софтуерната академия");
            }
        }

        // TODO REMOVE THIS BS FROM HERE, IT IS SUPPOSED TO BE IN "EntranceExamMainPage"!!!!!!!
      
    }
}